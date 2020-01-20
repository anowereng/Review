using System;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            var employee1 = new Employee() { EmployeedId = 2, EmpName = "anower", EmpType = 2, JobDescription = "job1", Salary = 20000 };
            var empfactory = new EmployeeManagerFactory();
            var empmanager = empfactory.EmployeeManager(employee1.EmpType);

            if (employee1.EmpType == 1)
            {
                employee1.Bonus = empmanager.GetBonus();
                employee1.HourlyPay = empmanager.GetHourlyPay();
            }
            else
            {
                employee1.Bonus = empmanager.GetBonus();
                employee1.HourlyPay = empmanager.GetHourlyPay();
            }
            Console.WriteLine("Employee Name:{0}\n Bonus:{1}\n HourlPay:{2}", employee1.EmpName, employee1.Bonus, employee1.HourlyPay);
            Console.ReadKey();
        }
    }
}
