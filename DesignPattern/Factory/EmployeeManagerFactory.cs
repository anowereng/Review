using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    public class EmployeeManagerFactory
    {
        public IEmployeeManager EmployeeManager(int id)
        {
            IEmployeeManager empmanager = null;
            if (id == 1)
            {
                empmanager = new PermenantEmployeeManager();
            }
            else
            {
                empmanager = new BasicEmployeeManager();
            }
            return empmanager;
        }
    }
}
