using System;
using System.Threading;

namespace MomentsClock
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Moments Clock"); // Initial Text
            CoolDown(); // Call the CoolDown method
        }

        public static void CoolDown()
        {
            Console.WriteLine("Starting timer in.. 3 seconds.."); //Start a timer of 3 seconds
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("3");
            Thread.Sleep(1000);
            Console.WriteLine("2");
            Thread.Sleep(1000);
            Console.WriteLine("1");
            Thread.Sleep(1000);
            Console.Clear();
            StopWatch(); // Call the StopWatch method
        }

        public static void StopWatch()
        {
            // Set the initial values.
            int Hours = 0;
            int Minutes = 0;
            int Seconds = 0;

            int Moments = 0;

            while (true) //While true do everything below
            {
                //Output to console the current times
                Console.WriteLine(Seconds + " seconds");
                Console.WriteLine(Minutes + " minutes");
                // Console.WriteLine(Hours + " hours");
                Console.WriteLine(Moments + " moments");
                Thread.Sleep(1000);
                //Increase seconds each second
                Seconds += 1;
                Console.Clear();
                
                if (Seconds % 90 == 0) //Every 90 seconds increase the moments by 1
                {
                    Moments += 1;
                }

                if (Seconds % 60 == 0) //Every 60 seconds increase the minutes by 1
                {
                    Minutes += 1;
                }

                // Increase the hour by one every 60 minutes and or every 40 moments equivalent.
                /*if (Minutes % 60 == 0 && Moments % 40 == 0)
                {
                    Hours += 1;
                }*/
            }
        }
    }
}