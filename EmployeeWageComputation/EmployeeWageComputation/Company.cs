using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    internal class Company
    {
        public string CompanyName;
        public float EmpWagePerHour;
        public int FullTime_WorkingHrs_PerDay;
        public int PartTime_WorkingHours_PerDay;
        public int MAX_WORKING_HRS;
        public int MAX_WORKING_DAYS;


        public Company(String CompanyName, int EmpWagePerhour, int FullTime_WorkingHrs_PerDay, int PartTime_WorkingHours_PerDay, int MAX_WORKING_HRS, int MAX_WORKING_DAYS)
        {
            this.CompanyName = CompanyName;
            this.EmpWagePerHour = EmpWagePerhour;
            this.FullTime_WorkingHrs_PerDay = FullTime_WorkingHrs_PerDay;
            this.PartTime_WorkingHours_PerDay = PartTime_WorkingHours_PerDay;
            this.MAX_WORKING_HRS = MAX_WORKING_HRS;
            this.MAX_WORKING_DAYS = MAX_WORKING_DAYS;

        }
    }
}

