using System;
using BackendCore.Common.DTO.Base;

namespace BackendCore.Common.DTO.Identity.LoginHistory.Parameters
{
    public class LoginHistoryFilter : MainFilter
    {
        public Guid? Id { get; set; }
        public string Username { get; set; }
    }
}
