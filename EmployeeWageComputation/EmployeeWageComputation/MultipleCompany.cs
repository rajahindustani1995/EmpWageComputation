using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    internal interface IMultipleCompany
    {
        public void AddCompany(string CompanyName, int EmpWagePerhour, int FullTime_WorkingHrs_PerDay, int PartTime_WorkingHours_PerDay, int MAX_WORKING_HRS, int MAX_WORKING_DAYS);
        public void CalculateEmpWage(string CompanyName);

    }
}
