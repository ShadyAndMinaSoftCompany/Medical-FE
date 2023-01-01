using System;
using BackendCore.Common.DTO.Base;

namespace BackendCore.Common.DTO.Identity.Role
{
    public class RoleDto : LookupDto<Guid?>
    {
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
