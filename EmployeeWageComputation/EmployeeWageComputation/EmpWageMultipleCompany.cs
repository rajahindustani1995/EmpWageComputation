using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    internal class EmpWageArray
    {
        const int isFullTime = 1;
        const int isPartTime = 2;

        int numOfCompany = 0;
        Company[] companyEmpWageArray;

        public EmpWageArray()
        {
            this.companyEmpWageArray = new Company[8];
        }

        //Execution starts here
        //Values are passed to the instance
        public void AddCompanyEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHrsInMonth)
        {
            companyEmpWageArray[this.numOfCompany] = new Company(company, empRatePerHour, numOfWorkingDays, maxHrsInMonth);

            //After values passed to a particular instance the index numOfCompany increses
            numOfCompany++;
        }

        //Passing each instance separately for calculation
        public void ComputeEmpWage()
        {
            for (int i = 0; i < numOfCompany; i++)
            {
                //Passing each instance for further calculation
                companyEmpWageArray[i].SetTotalEmpWage(this.ComputeEmpWage(this.companyEmpWageArray[i]));

                //Displaying values calculated for each instance
                Console.WriteLine(this.companyEmpWageArray[i].DisplayEmpWage());
            }
        }

        //Actual calculation logic
        public int ComputeEmpWage(Company companyEmpWage)
        {
            int empHrs;
            int totalEmpHrs = 0;
            int totalWorkingDays = 0;

            while (totalEmpHrs < companyEmpWage.maxHrsInMonth && totalWorkingDays < companyEmpWage.numOfWorkingDays)
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
                //Console.WriteLine("Day#:" + totalWorkingDays + " Emp Hrs : " + empHrs);
            }
            return totalEmpHrs * companyEmpWage.empRatePerHour;
            //Console.WriteLine("Total Employee Wage : " + totalEmpWage);
        }
    }

    
}
