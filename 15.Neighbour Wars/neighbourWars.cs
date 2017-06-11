using System;


namespace neighbourWars
{
    class Program
    {
        static void Main(string[] args)
        {
            int peshosDamage = int.Parse(Console.ReadLine());
            int GoshosDamage = int.Parse(Console.ReadLine());

            int peshosHealth = 100;
            int goshosHealth = 100;
            int counter = 1;

            while (true)
            {
                if (counter % 2 == 1)
                {
                    goshosHealth -= peshosDamage;
                    if (goshosHealth > 0)
                    {
                        Console.WriteLine($"Pesho used Roundhouse kick and reduced Gosho to {goshosHealth} health.");
                    }

                }
                else if (counter % 2 == 0)
                {
                    peshosHealth -= GoshosDamage;
                    if (peshosHealth > 0)
                    {
                        Console.WriteLine($"Gosho used Thunderous fist and reduced Pesho to {peshosHealth} health.");
                    }
                }
                if (counter % 3 == 0 && peshosHealth > 0 && goshosHealth > 0)
                {
                    goshosHealth += 10;
                    peshosHealth += 10;
                }
                if (peshosHealth <= 0)
                {
                    Console.WriteLine($"Gosho won in {counter}th round.");
                    break;
                }

                else if (goshosHealth <= 0)
                {
                    Console.WriteLine($"Pesho won in {counter}th round.");
                    break;
                }
                counter++;
            }
        }
    }
}