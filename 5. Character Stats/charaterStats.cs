﻿using System;


namespace _5.Character_Stats
{
    class charaterStats
    {
        static void Main()
        {
            string name = Console.ReadLine();
            int currentHealth = int.Parse(Console.ReadLine());
            int maxHealth = int.Parse(Console.ReadLine());
            int currentEnergy = int.Parse(Console.ReadLine());
            int maxEnergy = int.Parse(Console.ReadLine());

            Console.WriteLine($"Name: {name}");
            Console.WriteLine("Health: |{0}{1}|", new string('|', currentHealth),
                 new string('.', maxHealth - currentHealth));
            Console.WriteLine("Energy: |{0}{1}|", new string('|', currentEnergy),
                 new string('.', maxEnergy - currentEnergy));
        }
    }
}