using System;
using BackendCore.Entities.Entities.Base;
using BackendCore.Entities.Enum;

namespace BackendCore.Entities.Entities.Identity
{
    public class LoginHistory : BaseEntity<Guid>
    {
        public string UserId { get; set; }
        public string Username { get; set; }
        public string Platform { get; set; }
        public string IpAddress { get; set; }
        public string AuthenticationType { get; set; }
        public string Status { get; set; }
        public string Reason { get; set; }
    }
}
