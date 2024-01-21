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

            int totalNoOfDays = 20;
            int totalNoOfHrs = 100;
            int wageRate = 20;
            int daycount = 0;
            int hrscount = 0;

            while (daycount <= totalNoOfDays && hrscount <= totalNoOfHrs)
            {
                daycount += 1;
                hrscount += 8;
                Console.WriteLine($"Your salary at end of day {daycount} is " + (Convert.ToInt32(hrscount * wageRate)));


            }
            Console.ReadLine();
        }
    }
}
