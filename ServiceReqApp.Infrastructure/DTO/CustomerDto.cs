using System.ComponentModel.DataAnnotations;

namespace ServiceReqApp.Infrastructure.DTO
{
    public class CustomerDto
    {
        public int Id { get; set; }
        [Required]
        [Display(Name="Наименование организации")]
        public string Name { get; set; }
        [Required]
        [Display(Name = "Номер телефона")]
        public string PhoneNumber { get; set; }
        [Required]
        [Display(Name = "Адресс")]
        public string Address { get; set; }
        [Required]
        [Display(Name = "ФИО руководителя")]
        public string ManagerName { get; set; }
        [Required]
        [Display(Name = "Доп. информация")]
        public string CustomerInfo { get; set; }
    }
}