using System;

namespace Factory_Ex2_Print
{
    class Program
    {
        static void Main(string[] args)
        {
            IPrint obj;
            obj = InvoiceFactory.print(1);
            obj.print();
            obj = InvoiceFactory.print(2);
            obj.print();
            Console.ReadKey();
        }
    }
}
