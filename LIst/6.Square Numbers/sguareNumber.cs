using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Square_Numbers
{
    class sguareNumber
    {
        static void Main(string[] args)
        {
            using System;
            using System.Collections.Generic;
            using System.Linq;
            using System.Text;
            using System.Threading.Tasks;

namespace EXE
    {
        public class exe
        {
            public static void Main(string[] args)
            {
                var numbers = Console.ReadLine().Split(' ')
                    .Select(int.Parse).ToList();

                var result = new List<int>();

                foreach (var number in numbers)
                {
                    var sguare = Math.Sqrt(number);
                    if (sguare == (int)sguare)
                    {
                        result.Add(number);
                    }
                }
                result.Sort();
                result.Reverse();

                Console.WriteLine(string.Join(" ", result));
            }
        }
    }


}
    }
}
