using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    public class PermenantEmployeeManager : IEmployeeManager
    {
        public float GetHourlyPay()
        { 
            return 20;
        }
        public float GetBonus()
        { 
            return 16;
        }

    }
}
