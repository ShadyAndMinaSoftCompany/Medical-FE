//using System;
//using System.Collections.Generic;
//using System.Net;
//using System.Threading.Tasks;
//using BackendCore.Common.Core;
//using BackendCore.Common.DTO.Lookup.Action;
//using BackendCore.Common.DTO.Lookup.Status;
//using BackendCore.Common.DTO.Lookup.Supplier;
//using BackendCore.Entities.Entities.Lookup;
//using BackendCore.Service.Services.Base;
//using Microsoft.EntityFrameworkCore;

//namespace BackendCore.Service.Services.Lookups
//{
//    public class LookupService : BaseService<Status, AddStatusDto, StatusDto, long, long?>, ILookupService
//    {
//        #region Constructors

//        public LookupService(IServiceBaseParameter<Status> parameters) : base(parameters)
//        {
//        }

//        #endregion


//        #region Public Methods

//        /// <summary>
//        /// Get Statuses
//        /// </summary>
//        /// <returns></returns>
//        public async Task<IFinalResult> GetStatusesAsync()
//        {
//            var entities = await UnitOfWork.Repository.FindAsync(x => x.IsDeleted == false);
//            var data = Mapper.Map<IEnumerable<Status>, List<StatusDto>>(entities);
//            return new ResponseResult(data, HttpStatusCode.OK, null, "Success");
//        }
//        /// <summary>
//        /// Get Actions
//        /// </summary>
//        /// <returns></returns>
//        public async Task<IFinalResult> GetActionsAsync()
//        {
//            var entities = await UnitOfWork.GetRepository<Entities.Entities.Lookup.Action>().FindAsync(x => x.IsDeleted == false);
//            var data = Mapper.Map<IEnumerable<Entities.Entities.Lookup.Action>, List<ActionDto>>(entities);
//            return new ResponseResult(data, HttpStatusCode.OK, null, "Success");
//        }

//        /// <summary>
//        /// Get Suppliers
//        /// </summary>
//        /// <returns></returns>
//        public async Task<IFinalResult> GetSuppliersAsync()
//        {
//            var entities = await UnitOfWork.GetRepository<Supplier>().FindAsync(x => x.IsDeleted == false, include: r =>
//                 r.Include(b => b.ContactPersons));
//            var data = Mapper.Map<IEnumerable<Supplier>, List<SupplierDto>>(entities);
//            return new ResponseResult(data, HttpStatusCode.OK, null, "Success");
//        }

//        /// <summary>
//        /// Update Supplier
//        /// </summary>
//        /// <returns></returns>
//        public async Task<IFinalResult> UpdateSupplierAsync(AddSupplierDto model)
//        {
           
//            var entity = await UnitOfWork.GetRepository<Supplier>().FirstOrDefaultAsync(x => x.Id == model.Id, include: r =>
//               r.Include(b => b.ContactPersons));
//            if (entity == null)
//            {
//                Result = new ResponseResult(null, HttpStatusCode.BadRequest,
//                    message: "This supplier not found in database");
//            }
//            else
//            {
//                UnitOfWork.GetRepository<ContactPerson>().RemoveRange(entity.ContactPersons);
//                UnitOfWork.GetRepository<Supplier>().Remove(entity);


//                var supplier = Mapper.Map<AddSupplierDto, Supplier>(model);
//                 UnitOfWork.GetRepository<Supplier>().Add(supplier);

//                var affectedRows = await UnitOfWork.SaveChangesAsync();
//                if (affectedRows > 0)
//                    Result = new ResponseResult(null, HttpStatusCode.Created,
//                        message: "Data Updated Successfully");
//            }
//            return ResponseResult.PostResult(Result, HttpStatusCode.OK, message: HttpStatusCode.OK.ToString());

//        }
//        /// <summary>
//        /// Get Supplier by Id
//        /// </summary>
//        /// <returns></returns>

//        public async Task<IFinalResult> GetSupplierAsync(Guid supplierId)
//        {
//            var entities = await UnitOfWork.GetRepository<Supplier>().FirstOrDefaultAsync(x => x.Id == supplierId, include:
//             r =>
//                 r.Include(b => b.ContactPersons));
//            if (entities == null)
//            {
//                Result = new ResponseResult(null, HttpStatusCode.BadRequest,
//                    message: "This supplier not found in database");
//                return ResponseResult.PostResult(Result, HttpStatusCode.OK, message: HttpStatusCode.OK.ToString());
//            }
//            var data = Mapper.Map<Supplier, SupplierDto>(entities);
//            return new ResponseResult(data, HttpStatusCode.OK, null, "Success");
//        }
//        #endregion

//        #region Private Methods



//        #endregion



//    }
//}
