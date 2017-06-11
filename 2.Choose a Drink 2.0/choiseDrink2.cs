using System;


namespace _2.Choose_a_Drink_2._0
{
    class choiseDrink2
    {
        static void Main()
        {
            var profession = Console.ReadLine();
            var guantity = int.Parse(Console.ReadLine());

            if (profession == "Athlete")
            {
                Console.WriteLine("The {0} has to pay {1:f2}.", profession, guantity * 0.70);
            }
            else if (profession == "Businessman" || profession == "Businesswoman")
            {
                Console.WriteLine("The {0} has to pay {1:f2}.", profession, guantity * 1.00);
            }
            else if (profession == "SoftUni Student")
            {
                Console.WriteLine("The {0} has to pay {1:f2}.", profession, guantity * 1.70);
            }
            else
            {
                Console.WriteLine("The {0} has to pay {1:f2}.", profession, guantity * 1.20);
            }
        }
    }
}
