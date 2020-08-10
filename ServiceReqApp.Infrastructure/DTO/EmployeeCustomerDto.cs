using System.Collections;
using System.Collections.Generic;
using ServiceReqApp.Domain;

namespace ServiceReqApp.Infrastructure.DTO
{
    public class EmployeeCustomerDto
    {
        public ICollection<Employee> Employees { get; set; }
        public ICollection<Customer> Customers { get; set; }

        public EmployeeCustomerDto(ICollection<Customer> customers, ICollection<Employee> employees)
        {
            Customers = customers;
            Employees = employees;
        }
    }
}