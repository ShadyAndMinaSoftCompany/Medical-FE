using BackendCore.Entities.Entities.Base;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendCore.Entities.Entities.Business
{
    public class Department : BaseEntity<Guid>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Guid? FileId { get; set; }
        public virtual ICollection<Device> Devices { get; set; } = new Collection<Device>();

    }
}
