using System;

namespace EmpProject111
{
    class Program
    {
        static void Main(string[] args)
        {
           EmpWageObject avail = new EmpWageObject("Avail",20,2,10);
            EmpWageObject ncr = new EmpWageObject("NCR", 10, 4, 20);
            avail.ComputeEmpWage();
           // Console.WriteLine(avail.toString());
            ncr.ComputeEmpWage();
         //   Console.WriteLine("NCR",10,4,20);
            Console.ReadKey();
        }
    }
}
