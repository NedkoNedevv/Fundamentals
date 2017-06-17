using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Hello_name
{
    class helloName
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();          
            Console.WriteLine("Hello, {0}!", name);
        }
        static string GetName(string name)
        {
            return name;
        }
    }
}
