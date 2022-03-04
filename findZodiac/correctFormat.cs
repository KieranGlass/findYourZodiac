using System;
namespace findZodiac
{
    public class correctFormat
    {
        public static string monthFormat(string x)
        {
            while (!(x == "january" || x == "february" || x == "march" ||
                    x == "april" || x == "may" || x == "june" || x == "july" ||
                    x == "august" || x == "september" || x == "october" ||
                    x == "november" || x == "december"))
            {
                Console.WriteLine("Incorrect Format! Try Again");
                x = Console.ReadLine();
            } return x;
        }
        public static int dateFormat(int x)
        {
            while (!(x > 0 && x <= 31))
            {
                Console.WriteLine("Incorrect Format! Try Again");
                x = Convert.ToInt32(Console.ReadLine());
            } return x;
        }
    }
}