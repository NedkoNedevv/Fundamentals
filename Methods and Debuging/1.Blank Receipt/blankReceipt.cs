using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Blank_Receipt
{
    class blankReceipt
    {
        static void Main(string[] args)
        {
            PrintReceiptHeader();
        }
      static void PrintReceiptHeader()
        {
            PrintHeader();
            PrintBody();
            PrintFooter();
        }

        static void PrintHeader()
        {
            Console.WriteLine("CASH RECEIPT");
            Console.WriteLine("------------------------------");
        }
        static void PrintBody()
        {
            Console.WriteLine("Charged to____________________ ");
            Console.WriteLine("Received by___________________");
            Console.WriteLine("------------------------------");
        }
        static void PrintFooter()
        {
           Console.WriteLine("© SoftUni");
        }
    }
}
