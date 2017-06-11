using System;


namespace _4.Hotel
{
    class hotel
    {
        static void Main()
        {
            string month = Console.ReadLine().ToLower();
            var night = int.Parse(Console.ReadLine());

            var studioPrice = 0.0;
            var doublePrice = 0.0;
            var suitePrice = 0.0;

            switch (month)
            {
                case "may":
                case "october":
                    studioPrice = 50;
                    doublePrice = 65;
                    suitePrice = 75;
                    break;
                case "june":
                case "september":
                    studioPrice = 60;
                    doublePrice = 72;
                    suitePrice = 82;
                    break;
                case "july":
                case "august":
                case "december":
                    studioPrice = 68;
                    doublePrice = 77;
                    suitePrice = 89;
                    break;
                default:
                    break;
            }
            if (night > 7 && (month == "may" || month == "october"))
            {
                studioPrice *= 0.95;
            }
            else if (night > 14 && (month == "june" || month == "september"))
            {
                doublePrice *= 0.90;
            }
            else if (night > 14 && (month == "july" || month == "august" || month == "december"))
            {
                suitePrice *= 0.85;
            }
            var totalStudioPrice = studioPrice * night;
            var totalDoublePrice = doublePrice * night;
            var totalSuitePrice = suitePrice * night;

            if (night > 7 && (month == "october" || month == "september"))
            {
                totalStudioPrice -= studioPrice;
            }
            Console.WriteLine($"Studio: {totalStudioPrice:f2} lv.");
            Console.WriteLine($"Double: {totalDoublePrice:f2} lv.");
            Console.WriteLine($"Suite: {totalSuitePrice:f2} lv.");
        }
    }
}
