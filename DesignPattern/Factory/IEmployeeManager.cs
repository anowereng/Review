using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    public interface IEmployeeManager
    {
        public float GetHourlyPay();
        public float GetBonus();
    }
}
