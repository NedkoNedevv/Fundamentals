using System;


namespace _8.SMS_Typing_1
{
    class smsTyping
    {
        static void Main()
        {
            int inputCnt = int.Parse(Console.ReadLine());

            for (int i = 0; i < inputCnt; i++)
            {
                string input = Console.ReadLine();
                int currentDigit = input[0] - '0';

                if (input.Length > 0)
                {
                    currentDigit = input[0] - '0';
                }
                int charIndex = (currentDigit - 2) * 3 + (input.Length - 1);
                if (currentDigit == 8 || currentDigit == 9)
                {
                    charIndex += 1;
                }

                if (currentDigit == 0)
                {
                    Console.Write(' ');
                }
                else
                {
                    Console.Write((char)(charIndex + 'a'));
                }
            }
            Console.WriteLine();
        }
    }
}
