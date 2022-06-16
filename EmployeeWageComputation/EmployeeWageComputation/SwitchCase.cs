using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    internal class SwitchCase
    {
        public const int EmpAbsent = 0;
        public const int PartTime = 1;
        public const int FullTime = 2;
        public const int Wage_Per_Hour = 20;
        public const int Full_Day_Hour = 8;
        public const int PartTime_Day_Hour = 4;
        public int EmpDaily_Wage = 0;
        public int EmpWorkingHrs = 0;


        public int IsEmployeePresent()
        {
            return new Random().Next(0, 3);
        }

        public void CalculateWage()
        {



            switch (IsEmployeePresent())
            {
                case EmpAbsent:
                    EmpWorkingHrs = 0;
                    break;

                case PartTime:
                    EmpWorkingHrs = PartTime_Day_Hour;
                    break;
                case FullTime:
                    EmpWorkingHrs = Full_Day_Hour;
                    break;
            }
            EmpDaily_Wage = EmpWorkingHrs * Wage_Per_Hour;
            Console.WriteLine("Employee Daily Wage = " + EmpDaily_Wage);
        }
    }
}
