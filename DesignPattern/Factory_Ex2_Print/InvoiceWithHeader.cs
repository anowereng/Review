﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_Ex2_Print
{
    public class InvoiceWithHeader : IPrint
    {
        public void print()
        {
            Console.WriteLine("Print With Invoice Header");
        }
    }
}
