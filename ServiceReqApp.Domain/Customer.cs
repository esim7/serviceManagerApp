using System;
using System.Net.Cache;

namespace ServiceReqApp.Domain
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Description { get; set; }
    }
}