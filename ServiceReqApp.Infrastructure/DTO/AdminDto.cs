using System.Collections;
using System.Collections.Generic;
using ServiceReqApp.Domain;

namespace ServiceReqApp.Infrastructure.DTO
{
    public class AdminDto
    {
        public ICollection<User> Users { get; set; }
        public ICollection<Customer> Customers { get; set; }

        public AdminDto(ICollection<User> users, ICollection<Customer> customers)
        {
            Users = users;
            Customers = customers;
        }
    }
}