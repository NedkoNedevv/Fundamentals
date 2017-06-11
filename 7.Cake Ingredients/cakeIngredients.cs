using System;


namespace _7_Cake
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            int ingredientsNumber = 0;

            while (input != "Bake!")
            {
                Console.WriteLine($"Adding ingredient {input}.");
                input = Console.ReadLine();
                ingredientsNumber++;
            }

            Console.WriteLine($"Preparing cake with {ingredientsNumber} ingredients.");

            //string ingr;

            //for (int i = 0; i <= 20; i++)
            //{
            //    ingr = Console.ReadLine();

            //    if (ingr != "Bake!")
            //    {
            //        Console.WriteLine($"Adding ingredient {ingr}.");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"Preparing cake with {i} ingredients.");
            //        break;

        }
    }
}