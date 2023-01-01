using BackendCore.Entities.Entities.Base;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendCore.Entities.Entities.Business
{
    public class DeviceBrand : BaseEntity<Guid>
    {
      
        public Guid? DeviceId { get; set; }
        public Device Device { get; set; }
        public Guid? BrandId { get; set; }
        public Brand Brand { get; set; }
        public virtual ICollection<ModelDetail> ModelDetails { get; set; } = new Collection<ModelDetail>();

    }
}
