using System;

namespace BirthdayCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input Birthday (DD-MM-YYYY): ");
            DateTime Birthday = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", null);
            int Days = DaysPassedSinceYourBirth(Birthday);
            double Hours = HoursPassedSinceYourBirth(Birthday);
            double Minutes = MinutesPassedSinceYourBirth(Birthday);
            double Seconds = SecondsPassedSinceYourBirth(Birthday);
            Console.WriteLine("{0} Day", Days);
            Console.WriteLine("{0} Hours", Hours);
            Console.WriteLine("{0} Minutes", Minutes);
            Console.WriteLine("{0} Seconds", Seconds);
        }
        public static string GetMyInformation(string firstName, string lastName, string city, string country, DateTime dob)
        {
            return "";
        }
        public static int DaysPassedSinceYourBirth(DateTime dob)
        {
            TimeSpan interval = DateTime.Now - dob;
            int Days = interval.Days;
            //Console.WriteLine("{0} Day", interval.Days);
            return Days;
        }
        public static Double HoursPassedSinceYourBirth(DateTime dob)
        {
            TimeSpan interval = DateTime.Now - dob;
            double Hours = interval.Days * 24;
            return Hours;
        }
        public static Double MinutesPassedSinceYourBirth(DateTime dob)
        {
            TimeSpan interval = DateTime.Now - dob;
            double Minutes = interval.Days * 1440;
            return Minutes;
        }
        public static Double SecondsPassedSinceYourBirth(DateTime dob)
        {
            TimeSpan interval = DateTime.Now - dob;
            double Seconds = interval.Days * 86400;
            return Seconds;
        }
    }

}
