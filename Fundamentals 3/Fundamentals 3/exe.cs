using System;


namespace EXE
{
    class exe
    {
        static void Main()
        {
            double balance = double.Parse(Console.ReadLine());
            string input = string.Empty;

            double outFallPrice = 39.99;
            double csOfPrice = 15.99;
            double ZplinterZellPrice = 19.99;
            double honored2Price = 59.99;
            double roverWatchPrice = 29.99;
            double roverWatchEditionsPrice = 39.99;
            string currentGame = string.Empty;
            while (input != "Game Time")
            {
                double price = 0;
                if (input == "OutFall 4")
                {
                    currentGame = "OutFall 4";
                    price = outFallPrice;
                }
                else if (input == "CS:OG")
                {
                    currentGame = "CS:OG";
                    price = csOfPrice;
                }
                else if (input == "Zplinter Zell")
                {
                    currentGame = "Zplinter Zell";
                    price = ZplinterZellPrice;
                }
                else if (input == "Honored 2")
                {
                    currentGame = "Honored 2";
                    price = honored2Price;
                }
                else if (input == "RoverWatch")
                {
                    currentGame = "RoverWatch";
                    price = roverWatchPrice;
                }
                else if (input == "RoverWatch Origins Editions")
                {
                    currentGame = "RoverWatch Origins Editions";
                    price = roverWatchEditionsPrice;
                }
                else
                {
                    Console.WriteLine("Not Found");
                    input = Console.ReadLine();
                    continue;
                }

                if (price <= balance)
                {
                    Console.WriteLine("Bought: {0}", currentGame);
                }
            }

        }
    }
}
