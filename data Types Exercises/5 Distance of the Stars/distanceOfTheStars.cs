using System;


namespace _5_Distance_of_the_Stars
{
    class distanceOfTheStars
    {
        static void Main()
        {
            decimal kmForOnelightyear = 9450000000000M;
            decimal proxima = kmForOnelightyear * 4.22m;
            decimal centerMilky = kmForOnelightyear * 26000;
            decimal milkyWay = kmForOnelightyear * 100000;
            decimal edgeGalaxy = kmForOnelightyear * 46500000000;

            Console.WriteLine("{0:e2}", proxima);
            Console.WriteLine("{0:e2}", centerMilky);
            Console.WriteLine("{0:e2}", milkyWay);
            Console.WriteLine("{0:e2}", edgeGalaxy);
        }
    }
}
