using System;

namespace EmployeeWageComputation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computaion Program.");

            Random random = new Random();
            int wagePerHrs = 20;
            int fullDayHrs = 8;
            int partTimeHrs = 8;
            int workingDays = 20;
            int totalWorkingHours = 100;

            int totalWage = 0;
            int totalHours = 0;
            int daysWorked = 0;

            while (daysWorked < workingDays && totalHours < totalWorkingHours)
            {
                int attendance = random.Next(0, 2);

                switch (attendance)
                {
                    case 0:
                        Console.WriteLine("Employee is Present today");

                        int dailyWage = wagePerHrs * (fullDayHrs + partTimeHrs);
                        Console.WriteLine($"Daily Employee Wage : {dailyWage}");

                        totalWage += dailyWage;
                        totalHours += fullDayHrs + partTimeHrs;
                        daysWorked++;

                        break;
                    case 1:
                        Console.WriteLine("Employee is Absent today");
                        break;
                }
            }

            Console.WriteLine($"Total Monthly Employee Wage : {totalWage}");
            Console.WriteLine($"Total Working Days : {daysWorked}");
            Console.WriteLine($"Total Working Hours : {totalHours}");

            Console.ReadLine();
        }
    }
}
