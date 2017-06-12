using System;


namespace _8.Traveling_At_Light_Speed
{
    class lightSpeed
    {
        static void Main()
        {

            decimal lightYears = decimal.Parse(Console.ReadLine());

            decimal kmForLightYears = 9450000000000;
            decimal kmPerSecond = 300000;
   
            decimal secondsTotal = (lightYears * kmForLightYears) / kmPerSecond;

            int minutes = (int)(secondsTotal / 60);
            secondsTotal %= 60;
            int hours = (minutes / 60);
            minutes %= 60;
            int days = hours / 24;
            hours %= 24;
            int weeks = days / 7;
            days %= 7;

            Console.WriteLine("{0} weeks", weeks);
            Console.WriteLine("{0} days", days);
            Console.WriteLine("{0} hours", hours);
            Console.WriteLine("{0} minutes", minutes);
            Console.WriteLine("{0} seconds", (int)secondsTotal);
        }
    }
}
