using System.Threading.Tasks;
using BackendCore.Common.Core;
using BackendCore.Common.DTO.Identity.Login;

namespace BackendCore.Service.Services.Identity.Account
{
    public interface IAccountService
    {
        Task<IFinalResult> Login(LoginParameters parameters);

        Task<IFinalResult> ResetPassword(ResetPasswordParameters parameters);
    }
}