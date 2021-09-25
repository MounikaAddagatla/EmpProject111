using System;

namespace EmpProject111
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welocome to Employee Wage computation");
            WageCaluclation empWage = new WageCaluclation();
            empWage.Attendance();
            empWage.EmpWageCal();
            Console.ReadKey();
        }
    }
}
