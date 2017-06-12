using System;


namespace _9.Refactor_Special_Numbers
{
    class refactorSpecialNum
    {
        static void Main()
        {
            int input = int.Parse(Console.ReadLine());
            int sum = 0;
            int currentNUm = 0;
            bool result = false;

            for (int cnt = 1; cnt <= input; cnt++)
            {
                currentNUm = cnt;
                while (cnt > 0)
                {
                    sum += cnt % 10;
                    cnt = cnt / 10;
                }
                result = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine($"{currentNUm} -> {result}");
                sum = 0;
                cnt = currentNUm;
            }
        }
    }
}


