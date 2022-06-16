using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    internal class PartTimeEmployee
    {
        public int EmpPresent = 1;
        public int FullTime = 1;
        public int Wage_Per_Hour = 20;
        public int Full_Day_Hour = 8;
        public int PartTime_Day_Hour = 4;
        public int Daily_Wage = 0;

        public void PartTimeWage()
        {
            Random EmpCheck = new Random();
            int value = EmpCheck.Next(0, 2);

            if (value == EmpPresent)
            {
                Random TimeCheck = new Random();
                int WorkingHours = TimeCheck.Next(0, 2);
                if (WorkingHours == FullTime)
                {
                    Daily_Wage = Wage_Per_Hour * Full_Day_Hour;
                    Console.WriteLine("Employee Present Full Time so his Daily Wage is = " + Daily_Wage);
                }

                else
                {
                    Daily_Wage = Wage_Per_Hour * PartTime_Day_Hour;
                    Console.WriteLine("Employee Present Parttime so his Daily Wage is = " + Daily_Wage);
                }

            }
            else
            {
                Console.WriteLine("Employee is Absent");
                Console.WriteLine("Employee Daily Wage is = 0");
            }
        }
    }
}
