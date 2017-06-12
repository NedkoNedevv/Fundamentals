using System;


namespace _2.Circle_Perimeter__12_Digits_Precision_
{
    class circelPerimeter
    {
        static void Main()
        {
            double r = double.Parse(Console.ReadLine());
            double perimeters = 2 * Math.PI * r;
            Console.WriteLine("{0:f12}", perimeters);
        }
    }
}
