using System;


namespace _5.BPM_Counter
{
    class bmpCounter
    {
        static void Main()
        {
            double bmp = int.Parse(Console.ReadLine());
            double beats = int.Parse(Console.ReadLine());

            int minutes = 0;
            int seconds = 0;

            double bars = beats / 4.0;
            seconds = (int)((beats / bmp) * 60);
            minutes = seconds / 60;
            seconds = seconds % 60;

            Console.WriteLine("{0} bars - {1}m {2}s",
                Math.Round(bars, 1), minutes, seconds);
        }
    }
}
