using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlankReceipt
{
    class BlankReceipt
    {
        static void Main(string[] args)
        {
            printReciept();
        }

        private static void printReciept()
        {
            printRecieptHeader();
            printRecieptBody();
            printRecieptFooter();
        }

        private static void printRecieptFooter()
        {
            Console.WriteLine("------------------------------\n\u00A9 SoftUni");
        }

        private static void printRecieptBody()
        {
            Console.WriteLine(@"Charged to____________________
Received by___________________");
        }

        private static void printRecieptHeader()
        {
            Console.WriteLine("CASH RECEIPT");
            Console.WriteLine("------------------------------");
        }
    }
}
