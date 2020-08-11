using System;
using System.Collections;
using System.Collections.Generic;

namespace ServiceReqApp.Domain
{
    public class Employee
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public Position Position { get; set; }
        public ICollection<Request> Requests { get; set; }
        public string UserId { get; set; }
        public User User { get; set; }

        public Employee()
        {
            
        }

        public Employee(string fullName, Position position, User user)
        {
            FullName = fullName;
            Position = position;
            User = user;

            Requests = new List<Request>();
        }
    }
}