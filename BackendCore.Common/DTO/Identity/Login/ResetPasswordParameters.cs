using System;
using System.ComponentModel.DataAnnotations;

namespace BackendCore.Common.DTO.Identity.Login
{
    public class ResetPasswordParameters
    {
        [Required]
        public string Password { get; set; }
        [Required]
        public string ConfirmPassword { get; set; }
        [Required]
        public Guid UserId { get; set; }
    }
}