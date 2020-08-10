using System;
using System.Collections;
using System.Collections.Generic;

namespace ServiceReqApp.Domain
{
    public class Employee
    {
        public int Id { get; set; }
        public Position Position { get; set; }
        public ICollection<Request> Requests { get; set; }
        public string UserId { get; set; }
        public User User { get; set; }

        public Employee()
        {
            
        }

        public Employee(Position position, User user)
        {
            Position = position;
            User = user;

            Requests = new List<Request>();
        }
    }
}