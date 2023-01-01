using AutoMapper;
using BackendCore.Common.Core;
using BackendCore.Common.DTO.Business.Department;
using BackendCore.Common.DTO.Lookup.Department;
using BackendCore.Service.Services.Base;
using LinqKit;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BackendCore.Service.Services.Business.Department
{
    public class DepartmentService:
        BaseService<Entities.Entities.Business.Department, AddDepartmentDto, DepartmentDto, Guid, Guid?>, IDepartmentService

    {
        #region constructor

        public DepartmentService(IServiceBaseParameter<Entities.Entities.Business.Department> businessBaseParameter) : base(
            businessBaseParameter)
    {
    }

    #endregion


    #region Public Methods
    /// <summary>
    /// Get All Paged
    /// </summary>
    /// <param name="filter"></param>
    /// <returns></returns>
    public async Task<IFinalResult> GetAllAsync()
    {
       var entities = await UnitOfWork.Repository.GetAllAsync();
        var data = Mapper.Map<IEnumerable<Entities.Entities.Business.Department>, List<DepartmentDto>>(entities);
        return new ResponseResult(data, HttpStatusCode.OK, null, "Success");
    }



    #endregion


    #region Private Methods
   
    #endregion

}
}