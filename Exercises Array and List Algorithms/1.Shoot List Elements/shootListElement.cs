using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Shoot_List_Elements
{
    class shootListElement
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();

            string input = Console.ReadLine();
            int lastShootNumber = 0;
            while (true)
            {
                if (input == "bang")
                {
                    if (numbers.Count == 0)
                    {
                        Console.WriteLine("nobody left to shoot! last one was " + lastShootNumber);
                        break;
                    }
                    double average = numbers.Average();
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] < average)
                        {
                            lastShootNumber = numbers[i];
                            numbers.RemoveAt(i);
                            Console.WriteLine("shot " + lastShootNumber);
                            break;
                        }
                        else if (numbers.Count == 1)
                        {
                            lastShootNumber = numbers[0];
                            numbers.RemoveAt(0);
                            Console.WriteLine("shot " + lastShootNumber);
                            break;
                        }
                    }
                    numbers = numbers.Select(n => --n).ToList();
                }
                else if (input == "stop")
                {
                    if (numbers.Count == 0)
                    {
                        Console.WriteLine("you shot them all. last one was " + lastShootNumber);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("survivors: {0}", string.Join(" ", numbers));
                        break;
                    }
                }
                else
                {
                    int number = int.Parse(input);
                    numbers.Insert(0, number);
                }

                input = Console.ReadLine();
            }
           
        }
    }
}
