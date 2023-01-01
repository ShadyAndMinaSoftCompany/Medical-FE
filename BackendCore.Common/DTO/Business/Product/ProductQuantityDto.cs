using System;
using BackendCore.Common.Core;

namespace BackendCore.Common.DTO.Business.Product
{
    public class ProductQuantityDto : IEntityDto<Guid?>
    {
        public Guid? Id { get; set; }
        public int NewQuantity { get; set; } = 0;
    }
}
