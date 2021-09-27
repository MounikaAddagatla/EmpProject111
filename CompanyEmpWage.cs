using System;
using System.Collections.Generic;
using System.Text;

namespace EmpProject111
{
    class CompanyEmpWage
    {
        private string company;
        private readonly int empRatePerHour;
        private readonly int maxHoursPerMonth;

        public CompanyEmpWage(int totalEmpWage, int empRatePerHour = 0)
        {
            this.totalEmpWage = totalEmpWage;
            this.empRatePerHour = empRatePerHour;
        }

        private int totalEmpWage;

        public CompanyEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHourPerMonth)
        {
            this.company = company;
            this.empRatePerHour = empRatePerHour;
            this.NumOfWorkingDays = numOfWorkingDays;
            this.maxHoursPerMonth = maxHourPerMonth;
        }

        public int NumOfWorkingDays { get; set; }

        public void setTotalEmpWage(int totalEmpWage)
        {
            this.totalEmpWage = totalEmpWage;
        }
         
         
        public string toString()
        {
            return "Total Emp Wage for company :" + this.company + " is :" + this.totalEmpWage;
        }

        public override bool Equals(object obj)
        {
            return obj is CompanyEmpWage wage &&
                   totalEmpWage == wage.totalEmpWage;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(totalEmpWage);
        }
    }
}
