﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    public class EmployeeManager : IEmployeeManager
    {
        public float GetHourlyPay()
        { 
            return 10;
        }
        public float GetBonus()
        { 
            return 10;
        }

    }
}