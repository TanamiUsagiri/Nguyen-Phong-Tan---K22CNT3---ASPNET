﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Npt_Lesson04.Models
{
    public class NPTCustomer
    {
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public int YearOfBirth { get; set; }
    }
}