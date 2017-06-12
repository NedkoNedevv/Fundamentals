using System;


namespace _5.Special_Numbers
{
    class specialNumbers
    {
        static void Main()
        {
            int inputCnt = int.Parse(Console.ReadLine());

            for (int cnt = 1; cnt <= inputCnt; cnt++)
            {
                int num = cnt;
                int startingNum = num;
                int sum = 0;

                while (num > 0)
                {
                    int currentNum = num % 10;
                    num = num / 10;
                    sum += currentNum;

                }
                bool result = sum == 5 || sum == 7 || sum == 11;
                Console.WriteLine(startingNum + " -> " + result);
            }
        }
    }
}
