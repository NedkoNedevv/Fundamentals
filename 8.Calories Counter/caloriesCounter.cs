using System;


namespace _8.Calories_Counter
{
    class caloriesCounter
    {
        static void Main()
        {
            var numberOfProducts = int.Parse(Console.ReadLine());

            var calories = 0;

            var nameOfProducts = string.Empty;


            for (int i = 0; i < numberOfProducts; i++)
            {
                nameOfProducts = Console.ReadLine().ToLower();

                if (nameOfProducts == "cheese")
                {
                    calories += 500;
                }
                else if (nameOfProducts == "tomato sauce")
                {
                    calories += 150;
                }
                else if (nameOfProducts == "salami")
                {
                    calories += 600;
                }
                else if (nameOfProducts == "pepper")
                {
                    calories += 50;
                }
                else
                {
                    calories += 0;
                }
            }
            Console.WriteLine($"Total calories: {calories}");
        }
    }
}
