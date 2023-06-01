using Microsoft.AspNetCore.Components;
using System.ComponentModel.DataAnnotations;
using System.Linq.Expressions;

namespace TroutBlog.Data.Entities
{
    public class User
    {
        public int Id { get; set; }
        [Required]
        [StringLength(32,MinimumLength = 4, ErrorMessage="{0} length must be between {2} and {1} characters")]
        public string Username { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [StringLength(64, MinimumLength = 8, ErrorMessage = "{0} length must be between {2} and {1} characters")]
        public string Password { get; set; }
    }

}
