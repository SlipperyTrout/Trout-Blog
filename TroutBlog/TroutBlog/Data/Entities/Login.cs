using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace TroutBlog.Data.Entities
{
    public class UserLogin
    {
        [Required]
        public string? Email { get; set; }
        [Required]
        public string? Password { get; set; }

    }
}
