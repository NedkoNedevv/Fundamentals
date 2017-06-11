using System;


namespace _5.Word_in_Plural
{
    class wordInPlural
    {
        static void Main()
        {
            var word = Console.ReadLine();


            if (word.EndsWith("y"))
            {
                word = word.Remove(word.Length - 1);
                word += "ies";
            }
            else if (word.EndsWith("o") ||
                word.EndsWith("ch") || word.EndsWith("s") ||
                word.EndsWith("sh") || word.EndsWith("x") ||
                word.EndsWith("z"))
            {
                word += "es";
            }
            else
            {
                word += "s";
            }
            Console.WriteLine(word);
        }
    }
}
