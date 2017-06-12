using System;


namespace _17.Cypher_Roulette
{
    class cypherRulette
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            bool isReversed = false;
            string mesage = String.Empty;
            string previousString = String.Empty;

            for (int i = 0; i < n; i++)
            {
                string currentString = Console.ReadLine();
                if (currentString == previousString)
                {
                    mesage = String.Empty;
                    if (currentString == "spin")
                    {
                        n++;
                    }
                }
                else
                {
                    if (currentString == "spin")
                    {
                        isReversed = !isReversed;
                        n++;
                    }
                    else
                    {
                        if (isReversed)
                        {
                            mesage = currentString + mesage;
                        }
                        else
                        {
                            mesage += currentString;
                        }
                    }
                }
                previousString = currentString;
            }
            Console.WriteLine(mesage);
        }
    }
}
