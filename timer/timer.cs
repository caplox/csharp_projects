// With this c# program, you can start a stopwatch or start a countdown.

using System;

namespace countdownClock
{
    class Program
    {
        static void Main(string[] args)
        {
            char choiceSC= 'a';
            int year, month, day, hour, min, secs;

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Stopwatch or Countdown? Enter S/C: ");
                try
                {
                    choiceSC = Convert.ToChar(Console.ReadLine());
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid character, defaulting to countdown.");
                    Console.ForegroundColor = ConsoleColor.White;
                }


                if (choiceSC == 'C' || choiceSC == 'c')
                {
                    while (true)
                    {
                        try
                        {
                            Console.Write("Enter year: ");
                            year = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Enter month: ");
                            month = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Enter day: ");
                            day = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Enter hour: ");
                            hour = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Enter minute: ");
                            min = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Enter second: ");
                            secs = Convert.ToInt32(Console.ReadLine());
                        }
                        catch
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Write a valid value.");
                            Console.ForegroundColor = ConsoleColor.White;
                            break;
                        }

                        DateTime printDate = new DateTime(year, month, day, hour, min, secs);

                        // if the time right now is further than the input date, user needs to enter a new date.
                        if (DateTime.Now > printDate)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("This date has already passed.\n\n");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        // if now is smaller than the input date or the same time, start a while loop and print the input text if the time right now is equal to the input date
                        else if (DateTime.Now <= printDate)
                        {
                            while (true)
                            {
                                Console.WriteLine(printDate.Subtract(DateTime.Now));

                                if (DateTime.Now >= printDate)
                                {
                                    Console.WriteLine("Countdown is done!");
                                    break;
                                }
                            }
                        }
                        break;
                    }
                }


                else if (choiceSC == 'S' || choiceSC == 's')
                {
                    DateTime timeStartLoop = DateTime.Now;
                    while (true)
                    {
                        Console.WriteLine((DateTime.Now).Subtract(timeStartLoop));
                    }
                }


                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid character.");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
        }
    }
}
