using System;
using System.Collections.Generic;
using System.Text;

namespace EmpProject111
{
    internal class WageCaluclation : IEmpCompanyName
    {
        const int IS_PRESENT = 1, WAGE_PER_HOUR = 20, FULL_DAY_HR = 8, PART_DAY_HR = 4, IS_FULLTIME = 1, IS_PARTTIME = 2, WORKING_DAY_MONTH = 20, workingDays = 0, TOTAL_WORKING_HRS = 100;
        int totalEmpWage = 0, empHrs = 0, workDays = 0, working_days = 0, working_hrs = 0, dailyEmpWages = 0, working_day_month;
        readonly string company = "BridgeLabzs";
        public void Attendance()
        {
            Random random = new Random();
            int empCheck = random.Next(0, 2);
            if (empCheck == IS_PRESENT)
            {
                Console.WriteLine("Employee is Present");
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
        }

        public int ComputeEmpWage(string company, int wage_per_hr, int total_working_hrs, int working_day_month)
        {
            throw new NotImplementedException();
        }

        public void EmpWageCal()
        {
            Random random = new Random();
            int empCheck = random.Next(0, 3);
            while (workDays < WORKING_DAY_MONTH && empHrs <= TOTAL_WORKING_HRS)
            {
                workDays = workDays + 1;
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
                Console.WriteLine("emphrs: " + empHrs);
                //cal wages till workinghrs is 100 and workingdays is 20
                for (int i = 1; i < WORKING_DAY_MONTH; i++)
                {
                    totalEmpWage = empHrs * WAGE_PER_HOUR;
                }
                totalEmpWage = empHrs * WAGE_PER_HOUR;
                Console.WriteLine("working hrs: " + empHrs + ",working days:" + workingDays);
                Console.WriteLine("Total emp wage is: " + totalEmpWage);
              
                Console.WriteLine("Total employee wage for " + company + " of " + working_day_month + " days is :" + totalEmpWage);

            }
        }
    }
}

