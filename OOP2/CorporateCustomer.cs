﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    public class CorporateCustomer : Customer
    {
        public int Id { get; set; }
        public string CustomerNumber { get; set; }
        public string TaxNumber { get; set; }
        public string CompanyName { get; set; }
    }
}
