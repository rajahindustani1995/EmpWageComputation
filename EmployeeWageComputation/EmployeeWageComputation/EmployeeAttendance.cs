using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    internal class EmployeeAttendance
    {
        public int EmpPresent = 1;

        public void CheckEmpPresentAbsent()
        {
            Random EmpCheck = new Random();
            int value = EmpCheck.Next(0, 2);

            if (value == EmpPresent)
            {
                Console.WriteLine("Employee is Present");
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
        }
    }
}
