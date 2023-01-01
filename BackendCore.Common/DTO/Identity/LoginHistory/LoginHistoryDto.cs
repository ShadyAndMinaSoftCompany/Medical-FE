using System;
using BackendCore.Common.Core;

namespace BackendCore.Common.DTO.Identity.LoginHistory
{
    public class LoginHistoryDto : IEntityDto<Guid?>
    {
        public Guid? Id { get; set; }
        public string UserId { get; set; }
        public string Username { get; set; }
        public string Platform { get; set; }
        public string IpAddress { get; set; }
        public string AuthenticationType { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Status { get; set; }
        public string Reason { get; set; }
    }
}
