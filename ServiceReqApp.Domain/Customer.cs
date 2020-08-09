﻿using System;
using System.Net.Cache;

namespace ServiceReqApp.Domain
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string ManagerName { get; set; }
        public string CustomerInfo { get; set; }
    }
}