using BackendCore.Entities.Entities.Base;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendCore.Entities.Entities.Business
{
    public class Brand : BaseEntity<Guid>
    {
        public string Manufacturer { get; set; }
        public string Bidder { get; set; }
        public string CountryOfOrigin { get; set; }
        public virtual ICollection<DeviceBrand> DeviceBrands { get; set; } = new Collection<DeviceBrand>();

    }
}
