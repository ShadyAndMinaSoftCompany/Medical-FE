using BackendCore.Api.Controllers.Base;
using BackendCore.Common.Core;
using BackendCore.Common.Services;
using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System;
using BackendCore.Service.Services.Business.Department;

namespace BackendCore.Api.Controllers.Business
{

        /// <summary>
        /// Departments Controller
        /// </summary>
        public class DepartmentsController : BaseController
        {
            private readonly IDepartmentService _departmentService;


            /// <summary>
            /// Constructor
            /// </summary>
            public DepartmentsController( IDepartmentService departmentService)
            {
                _departmentService = departmentService;
            }



            /// <summary>
            /// Get Departments
            /// </summary>
            /// <returns></returns>
            [HttpGet]
            public async Task<IFinalResult> GetDepartments()
            {
                var result = await _departmentService.GetAllAsync();
                return result;
            }
        }
    }
   