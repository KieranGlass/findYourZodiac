using System;
namespace findZodiac
{
    public class ZodiacMethods
    {
        public static string ZodiacSign(string x, int y)
        {
            if ((x == "january" && y <= 19) || (x == "december" && y >= 22))
            {
                return "Capricorn";
            }
            else if ((x == "february" && y <= 18) || (x == "january" && y >= 20))
            {
                return "Aquarias";
            }
            else if ((x == "march" && y <= 20) || (x == "february" && y >= 19))
            {
                return "Pisces";
            }
            else if ((x == "april" && y <= 19) || (x == "march" && y >= 21))
            {
                return "Aries";
            }
            else if ((x == "may" && y <= 20) || (x == "april" && y >= 20))
            {
                return "Taurus";
            }
            else if ((x == "june" && y <= 20) || (x == "may" && y >= 21))
            {
                return "Gemini";
            }
            else if ((x == "july" && y <= 22) || (x == "june" && y >= 21))
            {
                return "Cancer";
            }
            else if ((x == "august" && y <= 22) || (x == "july" && y >= 23))
            {
                return "Leo";
            }
            else if ((x == "september" && y <= 22) || (x == "august" && y >= 23))
            {
                return "Virgo";
            }
            else if ((x == "october" && y <= 22) || (x == "september" && y >= 23))
            {
                return "Libra";
            }
            else if ((x == "november" && y <= 21) || (x == "october" && y >= 23))
            {
                return "Taurus";
            }
            else if ((x == "december" && y <= 21) || (x == "november" && y >= 22))
            {
                return "Taurus";
            }
            else
            {
                return "You messed up!";
            }
        }
    }
}






