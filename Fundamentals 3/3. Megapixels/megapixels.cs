using System;


namespace _3.Megapixels
{
    class megapixels
    {
        static void Main()
        {
            int widht = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            double result = (widht * height) / 1000000.0;
            Console.WriteLine("{0}x{1} => {2}MP", widht, height, Math.Round(result, 1));
        }
    }
}
