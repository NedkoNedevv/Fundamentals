using System;


namespace _4.Beverage_Labels
{
    class beverageLabels
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int volume = int.Parse(Console.ReadLine());
            int energy = int.Parse(Console.ReadLine());
            int sugar = int.Parse(Console.ReadLine());

            double coeficient = volume / 100.0;
            double calories = energy * coeficient;
            double sugars = sugar * coeficient;
            Console.WriteLine($"{volume}ml {name}:");
            Console.WriteLine($"{calories}kcal, {sugars}g sugars");
        }
    }
}
