using System.ComponentModel.DataAnnotations;

namespace DatingApp.API.DTO
{
    public class UserForRegisterDTO
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        [StringLength(8 , MinimumLength = 4 , ErrorMessage = " You must specify password length  between 4 and 8" )]
        public string PassWord { get; set; }
    }
}