using System;


namespace _4.Photo_Gallery
{
    class photoGalery
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            int day = int.Parse(Console.ReadLine());
            int month = int.Parse(Console.ReadLine());
            int year = int.Parse(Console.ReadLine());
            int hour = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int size = int.Parse(Console.ReadLine());
            int widht = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            string orientation = string.Empty;
            double transFormedSize = 0;
            string unit = string.Empty;

            if (size < 1000)
            {
                transFormedSize = size;
                unit = "B";
            }
            else if (size < 1000 * 1000)
            {
                transFormedSize = (size / 1000.0);
                unit = "KB";
            }
            else if (size < 1000 * 1000 * 1000)
            {
                unit = "MB";
                transFormedSize = size / (1000 * 1000.0);
            }

            if (widht > height)
            {
                orientation = "(landscape)";
            }
            else if (widht < height)
            {
                orientation = "(portrait)";
            }
            else if (widht == height)
            {
                orientation = "(square)";
            }
            Console.WriteLine("Name: DSC_{0}.jpg", number.ToString().PadLeft(4, '0'));
            Console.WriteLine("Date Taken: {0}/{1}/{2} {3}:{4}", day.ToString().PadLeft(2, '0'),
                month.ToString().PadLeft(2, '0'),
                year,
                hour.ToString().PadLeft(2, '0'),
                minutes.ToString().PadLeft(2, '0'));
            Console.WriteLine("Size: {0}{1}", transFormedSize, unit);
            Console.WriteLine("Resolution: {0}x{1} {2}",
                widht, height, orientation);
        }
    }
}
