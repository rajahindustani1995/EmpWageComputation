using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    internal class MultipleCompanies
    {
        const int isFullTime = 1;
        const int isPartTime = 2;

        public static void EmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHrsInMonth)
        {
            int empHrs = 0;
            int totalEmpHrs = 0;
            int totalWorkingDays = 0;
            while (totalEmpHrs < maxHrsInMonth && totalWorkingDays < numOfWorkingDays)
            {
                totalWorkingDays++;
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case isFullTime:
                        empHrs = 8;
                        break;
                    case isPartTime:
                        empHrs = 4;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                totalEmpHrs += empHrs;
                Console.WriteLine("Day#:" + totalWorkingDays + " Emp Hrs : " + empHrs);
                if (totalEmpHrs == maxHrsInMonth)
                {
                    Console.WriteLine("Total working hours condition has reached i.e. " + maxHrsInMonth + " hrs");
                }
                if (totalWorkingDays == numOfWorkingDays)
                {
                    Console.WriteLine("Total working days condition has reached i.e. " + numOfWorkingDays + " days");
                }
            }
            int totalEmpWage = totalEmpHrs * empRatePerHour;
            Console.WriteLine("Total Employee Wage for company " + company + " is : " + totalEmpWage);
        }
        public void Companies()
        {
            EmpWage("JEEP", 32, 20, 100);
            EmpWage("TATA", 38, 20, 100);
        }
    }
}
