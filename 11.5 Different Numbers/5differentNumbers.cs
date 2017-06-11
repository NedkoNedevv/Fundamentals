using System;


namespace _11._5_Different_Numbers
{
    class differentNumbers
    {
        static void Main(string[] args)
        {
            var min = int.Parse(Console.ReadLine());
            var max = int.Parse(Console.ReadLine());


            if (max - min < 4)
            {
                Console.WriteLine("No");
            }
            for (int first = min; first <= max; first++)
            {
                for (int second = min; second <= max; second++)
                {
                    for (int thurd = min; thurd <= max; thurd++)
                    {
                        for (int fourth = min; fourth <= max; fourth++)
                        {
                            for (int fifth = min; fifth <= max; fifth++)
                            {
                                if (first < second && second < thurd &&
                                     thurd < fourth && fourth < fifth)
                                {
                                    Console.WriteLine($"{first} {second} {thurd} {fourth} {fifth}");
                                }
                            }
                        }
                    }
                }
            }

        }
    }
}
