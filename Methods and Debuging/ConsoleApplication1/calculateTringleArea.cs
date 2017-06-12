using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateTringleArea

{
    class calculateTringleArea
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double area = TriangleArea(width, height);
            Console.WriteLine(area);
        }
        static double TriangleArea(double wigth, double height)
        {
            return wigth * height / 2;
        }
    }
}
