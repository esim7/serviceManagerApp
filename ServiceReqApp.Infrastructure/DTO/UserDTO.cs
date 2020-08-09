using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;
using ServiceReqApp.Domain;

namespace ServiceReqApp.Infrastructure.DTO
{
    public class UserDto : IdentityUser
    {
        [Required]
        [Display(Name = "Имя")]
        public string FirstName { get; set; }
        [Required]
        [Display(Name="Фамилия")]
        public string LastName { get; set; }

        [Required]
        [Display(Name = "Новый пароль")]
        [StringLength(100, ErrorMessage = "Пароль должен содержать как минимум 6 символов", MinimumLength = 6)]
        [DataType(DataType.Password)]
        public string PasswordCandidate { get; set; }

        public UserProfile UserProfile { get; set; }
        public Employee Employee { get; set; }
    }
}