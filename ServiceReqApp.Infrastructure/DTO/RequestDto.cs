using System;
using System.ComponentModel.DataAnnotations;
using ServiceReqApp.Domain;

namespace ServiceReqApp.Infrastructure.DTO
{
    public class RequestDto
    {
        [Display(Name="Идентификатор")]
        public int Id { get; set; }

        [Display(Name = "Информация")]
        [Required]
        public string Description { get; set; }
        
        [Display(Name = "Дата создания")]
        public DateTime CreationDate { get; set; } = DateTime.Now;
        
        [Display(Name = "Дата выполнения")]
        public DateTime CompletedDate { get; set; } = DateTime.MinValue;
        
        [Display(Name = "Тип заявки")]
        [Required]
        public RequestType RequestType { get; set; }
        
        [Display(Name = "Статус выполнения")]
        public bool IsCompleted { get; set; } = false;

        public int CustomerId { get; set; }
        
        [Display(Name = "Клиент")]
        [Required]
        public Customer Customer { get; set; }

        public int EmployeeId { get; set; }

        [Display(Name = "Исполнитель")]
        [Required]
        public Employee Employee { get; set; }
    }
}