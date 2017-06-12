using System;


namespace _2.Rectangle_Area
{
    class retrangleArea
    {
        static void Main()
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double area = width * height;
            Console.WriteLine($"{area:f2}");

        }
    }
}
