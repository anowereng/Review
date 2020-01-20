using System;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            var employee1 = new Employee() { EmployeedId = 1, EmpName = "anower", EmpType = 1,  JobDescription = "job1", Salary = 20000 };
            var employee2 = new Employee() { EmployeedId = 2, EmpName = "jahangir", EmpType = 2, Bonus = 8000, HourlyPay = 500, JobDescription = "job2", Salary = 30000 };
            if (employee1.EmpType == 1)
            {
                employee1.HourlyPay = 500;
                employee1.Bonus = 10000;
            }
            else
            {
                employee1.HourlyPay = 500;
                employee1.Bonus = 10000;
            }

        }
    }
}
