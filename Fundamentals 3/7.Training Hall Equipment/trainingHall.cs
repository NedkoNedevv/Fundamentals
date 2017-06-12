using System;


namespace _7.Training_Hall_Equipment
{
    class trainingHall
    {
        static void Main()
        {
            double money = double.Parse(Console.ReadLine());
            int itemsCnt = int.Parse(Console.ReadLine());

            double subtotal = 0;

            for (int i = 0; i < itemsCnt; i++)
            {
                string itemName = Console.ReadLine();
                double itemPrice = double.Parse(Console.ReadLine());
                int guantity = int.Parse(Console.ReadLine());

                if (guantity > 1)
                {
                    itemName += 's';
                }
                Console.WriteLine("Adding {0} {1} to cart.",
                     guantity, itemName);
                subtotal += guantity * itemPrice;
            }
            Console.WriteLine("Subtotal: ${0:f2}", subtotal);
            double result = money - subtotal;

            if (result > 0)
            {
                Console.WriteLine("Money left: ${0:f2}", result);
            }
            else
            {
                result = Math.Abs(result);
                Console.WriteLine("Not enough. We need ${0:f2} more.", result);
            }
        }
    }
}
