using System;


namespace _7.Greeting
{
    class greeting
    {
        static void Main()
        {
            string firstName = Console.ReadLine();
            string lasttName = Console.ReadLine();
            byte age = byte.Parse(Console.ReadLine());

            Console.WriteLine($"Hello, {firstName} {lasttName}. You are {age} years old.");
        }
    }
}
