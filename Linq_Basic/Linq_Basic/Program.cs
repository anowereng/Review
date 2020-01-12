using System;
using System.Linq;

namespace Linq_Basic
{
    class Program
    {
        static void Main(string[] args)
        {
            var personlist = new QueryString();

            /*  Query Use */

            /*  name result */
            var name_result = from person in personlist.Employeees
                              where person.Contains("a")
                              orderby person ascending
                              select person;

            /*  age result    */
            var age_result = from x in personlist.EmployeeAge
                             where x > 50
                             orderby x descending
                             select x;


            var emp_data = from z in personlist.EmployeeData.OfType<Employee>()
                           where z.EmpSalary > 5000
                           orderby z.EmpAge descending
                           select z;


            var emp_data2 = from k in personlist.EmployeeData.OfType<Employee>()
                            where (k.EmpAge > 40) && (k.EmpSalary > 30000)
                            orderby k.EmpSalary descending
                            select k;

            foreach (var emp in emp_data2)
            {
                Console.WriteLine("Employee Name:{0} \t Employee Salary {1}: ", emp.EmpName, emp.EmpSalary);
            }

            foreach (var emp in emp_data)
            {
                Console.WriteLine("Employee Name:{0} \t Employee Salary {1}: ", emp.EmpName, emp.EmpSalary);
            }

            foreach (var x in name_result)
            {
                Console.WriteLine($"Employee Name : " + x);
            }

            foreach (var x in age_result)
            {
                Console.WriteLine($"Age Name : " + x);
            }
            Console.ReadKey();
        }
    }
}
