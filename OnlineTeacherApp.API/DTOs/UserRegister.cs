using System.ComponentModel.DataAnnotations;

namespace OnlineTeacherApp.API.DTOs
{
    public class UserRegister
    {
        [Required]
        public string Username { get; set; }
        [Required]
        [StringLength(10, MinimumLength=4, ErrorMessage="You must specify password between 4 and 10 characters.")]
        public string Password { get; set; }
    }
}