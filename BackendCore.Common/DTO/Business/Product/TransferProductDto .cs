using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendCore.Common.DTO.Business.Product
{
    public class TransferProductDto
    {
        public Guid  ProductId { get; set; }
        public Guid ShopId { get; set; }
        public int Quantity { get; set; }
    }
}
