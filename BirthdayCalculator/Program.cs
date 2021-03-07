using System;

namespace BirthdayCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to your personal age calcualtor");
            Console.WriteLine("Please provide me your details");
            Console.Write("First Name: ");
            string firstName = Console.ReadLine();
            Console.Write("Last Name: ");
            string lastName = Console.ReadLine();
            Console.Write("City: ");
            string city = Console.ReadLine();
            Console.Write("Country: ");
            string country = Console.ReadLine();           
            Console.Write("Dae for birth (DD-MM-YYYY): ");
            DateTime Birthday = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", null);
            string Result = GetMyInformation(firstName, lastName, city,country, Birthday);
            Console.WriteLine(Result);
            Console.Write("Press any key continue");
            Console.ReadLine();
        }
        public static string GetMyInformation(string firstName, string lastName, string city, string country, DateTime dob)
        {
            int Days = DaysPassedSinceYourBirth(dob);
            double Hours = HoursPassedSinceYourBirth(dob);
            double Minutes = MinutesPassedSinceYourBirth(dob);
            double Seconds = SecondsPassedSinceYourBirth(dob);
            Console.WriteLine("*** Hear are your details ***");
            Console.WriteLine("Name: {0} {1}", firstName, lastName);
            Console.WriteLine("  City: {0}", city);
            Console.WriteLine("  Country: {0}", country);
            Console.WriteLine("  Date of birth: {0}", dob);
            Console.WriteLine("****************************");
            Console.WriteLine("*** Here are your age numgers ***");
            Console.WriteLine("Your age in day : {0}", Days);
            Console.WriteLine("Your approximate age in horus: {0}", Hours);
            Console.WriteLine("Your approximate age in minutes: {0}", Minutes);
            Console.WriteLine("Your approximate age in seconds: {0}", Seconds);
            return "***Thank You***";
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
