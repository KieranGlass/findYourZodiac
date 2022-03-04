using System;

namespace findZodiac
{
    class Program
    {
        static void Main(string[] args)
        {

            string birthMonth;
            int birthDay;
            string methodInput;
            int value;
            string yourZodiac;
            

            Console.WriteLine("Find out your Zodiac! Press Enter to Continue!");
            Console.ReadLine();

            Console.WriteLine("Which Month were you Born!? Spell the month correctly!");
            birthMonth = correctFormat.monthFormat(Console.ReadLine());

            Console.WriteLine("Which day in " + birthMonth + " were you Born!? Whole numbers only!");
            methodInput = Console.ReadLine();
            while (!(int.TryParse(methodInput, out value)))
            {
                Console.WriteLine("Incorrect Format!");
                methodInput = Console.ReadLine();
            }
            birthDay = correctFormat.dateFormat(value);

            yourZodiac = ZodiacMethods.ZodiacSign(birthMonth, birthDay);

            Console.WriteLine("You are a " + yourZodiac);
            Console.ReadLine();

        }
    }
}
