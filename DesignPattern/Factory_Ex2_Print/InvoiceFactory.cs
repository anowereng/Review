using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_Ex2_Print
{
    public class InvoiceFactory
    {
        public static IPrint print(int printmethod)
        {
            IPrint print = null;
            if (printmethod == 1)
                print = new InvoiceWithHeader();
            else
                print = new InvoiceWithOutHeader();
            return print;
        }
    }
}
