﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tutoWebApi.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string Departement { get; set; }
        public string EmployeeName { get; set; }
        public string DateOfJoining { get; set; }
        public string PhotoFileName { get; set; }
    }
}