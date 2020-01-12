using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Linq_Basic
{
   
    public class QueryString
    {
        public string[] Employeees = { "anower", "Jahed", "akamal", "sazzad", "Hamza" };

        public int[] EmployeeAge = { 40, 60, 70, 23, 52 };

        public ArrayList EmployeeData = new ArrayList() { 
            new Employee { EmpId = 2525, EmpName = "anower", EmpAge = 35, EmpSalary = 25000 },
            new Employee { EmpId = 2525, EmpName = "Sajjad", EmpAge = 40, EmpSalary = 65000 },
            new Employee { EmpId = 2525, EmpName = "Kabir", EmpAge = 45, EmpSalary = 30000 },
            new Employee { EmpId = 2525, EmpName = "Kalim", EmpAge = 50, EmpSalary = 40000 },
        };
    }
}
