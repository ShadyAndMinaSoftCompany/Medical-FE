using BackendCore.Entities.Entities.Base;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendCore.Entities.Entities.Business
{
    public class Device : BaseEntity<Guid>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Guid? FileId { get; set; }
        public Guid? DepartmentId { get; set; }
        public Department Department { get; set; }

        public virtual ICollection<DeviceBrand> DeviceBrands { get; set; } = new Collection<DeviceBrand>();

    }
}