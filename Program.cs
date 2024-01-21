using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computaion Program.");

            Random random = new Random();
            int attendance = random.Next(0, 2);

            int wagePerHrs = 20;
            int fullDayHrs = 8;
            int partTimeHrs = 8;

            if (attendance == 1)
            {
                Console.WriteLine("Employee is Present today");

                int dailyWage = wagePerHrs * (fullDayHrs + partTimeHrs) ;
                Console.Write($"Daily Employee Wage : {dailyWage}");
            }
            else
            {
                Console.WriteLine("Employee is Absent today");
            }



            Console.ReadLine();
        }
    }
}
