using System;


namespace _2.Back_in_30_min
{
    class backIn30Min
    {
        static void Main()
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            minutes += 30;

            hours += minutes / 60;
            minutes = minutes % 60;

            if (hours >= 24)
            {
                hours = 0;
            }
            Console.WriteLine("{0}:{1:D2}", hours, minutes);
        }
    }
}
