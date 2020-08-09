using System.ComponentModel.DataAnnotations;

namespace ServiceReqApp.Infrastructure.DTO
{
    public class ChangePasswordDto
    {
        public string Id { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Неверный формат пароля", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Пароль")]
        public string PasswordCandidate { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Повторите пароль")]
        [Compare("PasswordCandidate", ErrorMessage = "Пароль и подтверждение не совпадают.")]
        public string ConfirmPassword { get; set; }
    }
}