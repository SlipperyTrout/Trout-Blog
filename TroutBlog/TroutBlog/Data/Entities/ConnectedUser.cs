using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TroutBlog.Data.Entities
{
    public class ConnectedUser
    {
        [Required]
        [EmailAddress, StringLength(32,MinimumLength = 4, ErrorMessage="{0} length must be between {2} and {1} characters")]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
