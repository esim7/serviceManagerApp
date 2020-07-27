using System;

namespace ServiceReqApp.Domain
{
    public class Request
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public DateTime CreationDate { get; set; } = DateTime.Now;
        public DateTime CompletedDate { get; set; } = DateTime.MinValue;
        public RequestType RequestType { get; set; }
        public bool IsCompleted { get; set; } = false;

        public int  CustomerId { get; set; }
        public Customer Customer { get; set; }
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
    }
}