using System;

namespace CalendarApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a date (YYYY-MM-DD): ");
            string inputDate = Console.ReadLine();

            if (DateTime.TryParse(inputDate, out DateTime date))
            {
                string dayOfWeek = date.DayOfWeek.ToString();
                Console.WriteLine($"The day of the week for {date.ToShortDateString()} is {dayOfWeek}.");
            }
            else
            {
                Console.WriteLine("Invalid date format.");
            }
        }
    }
}
