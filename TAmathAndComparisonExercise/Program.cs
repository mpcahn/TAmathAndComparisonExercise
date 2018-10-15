using System;

namespace TAmathAndComparisonExercise
{
    class Program
    {
        static void Main()
        {
            // The program must start by printing “Anonymous Income Comparison Program” to the screen.
            Console.WriteLine("Anonymous Income Comparison Program");

            // It must then print “Person 1” to the screen and get the following details:
            Console.WriteLine("Person 1");

            // -    Hourly Rate
            Console.WriteLine("Hourly Rate?");
            byte p1HourlyRate = Convert.ToByte(Console.ReadLine());

            // -    Hours worked per week
            Console.WriteLine("Hours per week?");
            byte p1HoursPerWeek = Convert.ToByte(Console.ReadLine());

            // It must then print “Person 2” to the screen and then get the following details:
            // -    Hourly rate
            // -    Hours worked per week
            Console.WriteLine("Person 2");

            // -    Hourly Rate
            Console.WriteLine("Hourly Rate?");
            byte p2HourlyRate = Convert.ToByte(Console.ReadLine());

            // -    Hours worked per week
            Console.WriteLine("Hours per week?");
            byte p2HoursPerWeek = Convert.ToByte(Console.ReadLine());

            // It must then print to the screen “Annual salary of Person 1:” and write the exact salary below it.
            int p1WeeklySalery = p1HourlyRate * p1HoursPerWeek;
            int p2WeeklySalery = p2HourlyRate * p2HoursPerWeek;

            Console.WriteLine("Weekly Salary of Person 1:");
            Console.WriteLine(p1WeeklySalery);

            // It must then print to the screen “Annual salary of Person 2:” and write the exact salary below it.
            Console.WriteLine("Weekly Salary of Person 2:");
            Console.WriteLine(p2WeeklySalery);

            // It must then print to the screen “Does Person 1 make more money than Person 2 ?” and write the true or false value of this statement below it.
            Console.WriteLine("Does Person 1 make more money than Person 2?");
            Console.WriteLine(p1WeeklySalery > p2WeeklySalery);
            Console.ReadLine();
        }
    }
}
