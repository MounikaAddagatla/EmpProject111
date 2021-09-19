using System;
using System.Collections.Generic;
using System.Text;

namespace EmpProject111
{
    class WageCaluclation
    {
        const int IS_PRESENT = 1, WAGE_PER_HOUR = 20, FULL_DAY_HR = 8, PART_DAY_HR = 4, IS_FULLTIME = 1, IS_PARTTIME = 2;
        int totalEmpWage = 0, partTimeEmpWage = 0, empHrs = 0;
        public void Attendance()
        {
            Random random = new Random();
            int empCheck = random.Next(0, 2);
            if (empCheck == IS_PRESENT)
                Console.WriteLine("Employee is Present");
            else
                Console.WriteLine("Employee is Absent");
        }
    public void EmpWageCal()
    {
        Random random = new Random();
        int empCheck = random.Next(0, 3);
            if (empCheck == IS_PRESENT)
                {
                    totalEmpWage = WAGE_PER_HOUR * FULL_DAY_HR;
                }
            
            else
            {
                totalEmpWage = 0;
            }
            switch (empCheck)
            {
                case IS_FULLTIME:
                    empHrs += FULL_DAY_HR;
                    break;
                case IS_PARTTIME:
                    empHrs += PART_DAY_HR;
                    break;
                default:
                    empHrs += 0;
                    break;
            }
            totalEmpWage = empHrs * WAGE_PER_HOUR;
            Console.WriteLine("Total emp wage is: " + totalEmpWage);
    }
    }
}

