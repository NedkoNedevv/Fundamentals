using System;


namespace _4.Transport
{
    class trasport
    {
        static void Main()
        {
            int people = int.Parse(Console.ReadLine());

            double courses = Math.Ceiling((double)people / (4 + 8 + 12));
            Console.WriteLine(courses);
        }
    }
}
