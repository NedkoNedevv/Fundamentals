using System;


namespace _8.Refactor_heightolume_of_Pyramid
{
    class refactorheightolume
    {
        static void Main()
        {
            double length, width, height = 0;

            Console.Write("Length: ");
            length = double.Parse(Console.ReadLine());

            Console.Write("Width: ");
            width = double.Parse(Console.ReadLine());

            Console.Write("Height: ");
            height = double.Parse(Console.ReadLine());

            double volume = (length * width * height) / 3;
            Console.WriteLine("Pyramid Volume: {0:f2}", volume);
        }
    }
}
