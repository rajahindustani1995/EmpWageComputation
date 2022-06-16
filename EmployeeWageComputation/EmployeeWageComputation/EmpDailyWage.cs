using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    internal class EmpDailyWage
    {
        public int EmpPresent = 1;
        public int Wage_Per_Hour = 20;
        public int Full_Day_Hour = 8;


        public void DailyWage()
        {
            Random EmpCheck = new Random();
            int value = EmpCheck.Next(0, 2);

            if (value == EmpPresent)
            {
                int Daily_Wage = Wage_Per_Hour * Full_Day_Hour;
                Console.WriteLine("Employee is Present");
                Console.WriteLine("Employee Daily Wage is = " + Daily_Wage);
            }
            else
            {
                Console.WriteLine("Employee is Absent");
                Console.WriteLine("Employee Daily Wage is = 0");
            }
        }
    }
}
