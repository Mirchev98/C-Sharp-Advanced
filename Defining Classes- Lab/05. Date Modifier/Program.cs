using System;

namespace _05._Date_Modifier
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string date1 = Console.ReadLine();
            string date2 = Console.ReadLine();

            int difference = DateModifier.DateDifference(date1, date2);

            Console.WriteLine(difference);
        }
    }
}
