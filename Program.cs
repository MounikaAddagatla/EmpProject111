using System;

namespace EmpProject111
{
    class Program
    {
        static void Main(string[] args)
        {
            EmpWageBuilderArray empWageBuilder = new EmpWageBuilderArray();
            empWageBuilder.addCompanyEmpWage("Avail", 20, 2, 10);
            empWageBuilder.addCompanyEmpWage("NCR", 20, 2, 10);
            empWageBuilder.addCompanyEmpWage();
            Console.ReadKey();
        }
    }
}
