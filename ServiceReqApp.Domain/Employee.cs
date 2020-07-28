using System.Collections;
using System.Collections.Generic;

namespace ServiceReqApp.Domain
{
    public class Employee
    {
        public int Id { get; set; }
        public string Position { get; set; }
        public ICollection<Request> Requests { get; set; }
        public string UserId { get; set; }
        public User User { get; set; }

        public Employee()
        {
            Requests = new List<Request>();
        }
    }
}