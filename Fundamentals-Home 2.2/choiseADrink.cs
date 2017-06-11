using System;


namespace Choose_a_Drink
{
    class choiseADrink
    {
        static void Main()
        {

            var profession = Console.ReadLine();

            if (profession == "Athlete")
            {
                Console.WriteLine("Water");
            }
            else if (profession == "Businessman" && profession == "Businesswoman")
            {
                Console.WriteLine("Coffe");
            }
            else if (profession == "SoftUni Student")
            {
                Console.WriteLine("Beer");
            }
            else
            {
                Console.WriteLine("Tea");
            }
        }
    }
}
