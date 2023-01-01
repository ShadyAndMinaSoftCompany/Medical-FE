using System;
using System.Net;
using System.Threading.Tasks;
using BackendCore.Common.Core;
using BackendCore.Common.DTO.Identity.Login;
using BackendCore.Common.DTO.Identity.User;
using BackendCore.Common.Extensions;
using BackendCore.Entities.Enum;
using BackendCore.Service.Services.Base;
using Microsoft.EntityFrameworkCore;

namespace BackendCore.Service.Services.Identity.Account
{
    public class AccountService : BaseService<Entities.Entities.Identity.User, AddUserDto, UserDto, Guid, Guid?>, IAccountService
    {
        private readonly ITokenService _tokenBusiness;
        public AccountService(IServiceBaseParameter<Entities.Entities.Identity.User> businessBaseParameter, ITokenService tokenBusiness) : base(businessBaseParameter)
        {
            _tokenBusiness = tokenBusiness;
        }

        #region Public Methods

        public async Task<IFinalResult> Login(LoginParameters parameters)
        {
            var user = await UnitOfWork.Repository.FirstOrDefaultAsync(q => q.UserName == parameters.Username && !q.IsDeleted, disableTracking: false);
            //include: source => 
            //    source.Include(a => a.Role), disableTracking: false);
            if (user == null)
            {
                await AddLoginHistory(LoginStatus.Failed, "Wrong Username Or Password", parameters);
                return ResponseResult.PostResult(status: HttpStatusCode.BadRequest,
                message: "Wrong Username or Password");

            }
            var rightPass = CryptoHasher.VerifyHashedPassword(user.PasswordHash, parameters.Password);
            if (!rightPass)
            {
                await AddLoginHistory(LoginStatus.Failed, "Wrong Password", parameters);
                return ResponseResult.PostResult(status: HttpStatusCode.NotFound, message: "Wrong Password");
            }
           // var role = user.RoleId;
            var userDto = Mapper.Map<Entities.Entities.Identity.User, UserDto>(user);
            var userLoginReturn = _tokenBusiness.GenerateJsonWebToken(userDto, string.Empty);
            await AddLoginHistory(LoginStatus.Success, "Success Attempt", parameters, user.Id.ToString());
            return ResponseResult.PostResult(userLoginReturn, status: HttpStatusCode.OK, message: HttpStatusCode.OK.ToString());
        }


        public async Task<IFinalResult> ResetPassword(ResetPasswordParameters parameters)
        {
            var entity = await UnitOfWork.Repository.GetAsync(parameters.UserId);
            if (entity == null)
                return ResponseResult.PostResult(status: HttpStatusCode.BadRequest,
                    message: "Wrong Username ");

            if (parameters.Password != parameters.ConfirmPassword)
            {
                return ResponseResult.PostResult(status: HttpStatusCode.BadRequest,
                    message: "Passwords Not Matched");
            }

            entity.PasswordHash = CryptoHasher.HashPassword(parameters.Password);
            SetEntityModifiedBaseProperties(entity);
            await UnitOfWork.Repository.UpdateAsync(entity.Id, entity);
            var affectedRows = await UnitOfWork.SaveChangesAsync();
            if (affectedRows > 0)
            {
                return ResponseResult.PostResult( true,status: HttpStatusCode.OK,
                    message: "Passwords Resetting Successfully");
            }

            return ResponseResult.PostResult(status: HttpStatusCode.BadRequest,
                message: "Error Resetting Password");
        }


        #endregion

        #region Private Methods

        private async Task AddLoginHistory(LoginStatus status, string reason, LoginParameters parameters, string userId = null)
        {
            var loginHistory = new Entities.Entities.Identity.LoginHistory
            {
                Username = parameters.Username,
                AuthenticationType = "JWT",
                Status = status.GetName().NameEn,
                Reason = reason,
                CreatedDate = DateTime.Now,
                IsDeleted = false,
                Platform = "",
                UserId = userId,
                IpAddress = ClaimData.IpAddress
            };

            UnitOfWork.GetRepository<Entities.Entities.Identity.LoginHistory>().Add(loginHistory);
            await UnitOfWork.SaveChangesAsync();

        }
        #endregion

    }
}