
using BackendCore.Common.DTO.Business.Attachment;
using BackendCore.Common.DTO.Business.Brand;
using BackendCore.Common.DTO.Business.Department;
using BackendCore.Common.DTO.Business.Device;
using BackendCore.Common.DTO.Business.DeviceBrand;
using BackendCore.Common.DTO.Business.ModelDetail;
using BackendCore.Common.DTO.Lookup.Department;
using BackendCore.Entities.Entities.Business;

// ReSharper disable once CheckNamespace
namespace BackendCore.Service.Mapping
{
    public partial class MappingService
    {
        public void MapBusiness()
        {
            CreateMap<Brand, AddBrandDto>()
                .ReverseMap();

            CreateMap<Brand, BrandDto>()
                .ReverseMap();

            CreateMap<Department, AddDepartmentDto>()
               .ReverseMap();

            CreateMap<Department, DepartmentDto>()
                .ReverseMap();

            CreateMap<Device, AddDeviceDto>()
              .ReverseMap();

            CreateMap<Device, DeviceDto>()
                .ReverseMap();

            CreateMap<DeviceBrand, AddDeviceBrandDto>()
             .ReverseMap();

            CreateMap<DeviceBrand, DeviceBrandDto>()
                .ReverseMap();

            CreateMap<ModelDetail, AddModelDetailDto>()
            .ReverseMap();

            CreateMap<ModelDetail, ModelDetailDto>()
                .ReverseMap();
        }
    }
}