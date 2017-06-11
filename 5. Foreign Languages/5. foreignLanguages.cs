using System;


namespace _5.Foreign_Languages
{
    class Program
    {
        static void Main()
        {
            var country = Console.ReadLine();

            if (country == "England" || country == "USA")
            {
                Console.WriteLine("English");
            }
            else if (country == "Spain" || country == "Argentina"
                || country == "Mexico")
            {
                Console.WriteLine("Spanish");
            }
            else
            {
                Console.WriteLine("unknown");
            }
        }
    }
}
