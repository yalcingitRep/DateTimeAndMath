using System;
namespace DateTimeAndMath{
    class Program{
        public static void Main(string[] args){
          Console.WriteLine(DateTime.Now);
          Console.WriteLine(DateTime.Now.Date);
          Console.WriteLine(DateTime.Now.Day);
          Console.WriteLine(DateTime.Now.Month);
          Console.WriteLine(DateTime.Now.Year);
          Console.WriteLine(DateTime.Now.Hour);
          Console.WriteLine(DateTime.Now.Minute);
          Console.WriteLine(DateTime.Now.Second);
          Console.WriteLine(DateTime.Now.DayOfWeek);
          Console.WriteLine(DateTime.Now.DayOfYear);

            Console.WriteLine(DateTime.Now.ToLongDateString());
            Console.WriteLine(DateTime.Now.ToShortTimeString());

            Console.WriteLine(DateTime.Now.ToLongTimeString());
            Console.WriteLine(DateTime.Now.ToShortTimeString());

            Console.WriteLine(DateTime.Now.AddDays(2));
            Console.WriteLine(DateTime.Now.AddHours(3));
            Console.WriteLine(DateTime.Now.AddSeconds(30));
            Console.WriteLine(DateTime.Now.AddMonths(5));
            Console.WriteLine(DateTime.Now.AddYears(10));

            Console.WriteLine(DateTime.Now.ToString("dd"));
            Console.WriteLine(DateTime.Now.ToString("ddd"));
            Console.WriteLine(DateTime.Now.ToString("dddd")); //saturday

            Console.WriteLine(DateTime.Now.ToString("MM"));
            Console.WriteLine(DateTime.Now.ToString("MMM"));
            Console.WriteLine(DateTime.Now.ToString("MMMM"));

            Console.WriteLine(DateTime.Now.ToString("yy"));//24
            Console.WriteLine(DateTime.Now.ToString("yyy"));//2024
          
          Console.WriteLine(Math.Abs(-24));

          Console.WriteLine(DateTime.Now.ToString("dd"));
            Console.WriteLine(Math.Sin(10));
            Console.WriteLine(Math.Cos(10));

            Console.WriteLine(Math.Ceiling(22.3));
            Console.WriteLine(Math.Ceiling(22.3));
            Console.WriteLine(Math.Round(22.3));

            Console.WriteLine(Math.Max(2,5));
            Console.WriteLine(Math.Pow(2,5));
            Console.WriteLine(Math.Sqrt(9));

        }
    }
}