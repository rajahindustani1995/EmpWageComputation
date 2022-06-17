using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    internal class UsingArrayList
    {
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;
        private Dictionary<string, Company> CompaniesDict;
        //Declaring Array
        //public string[] CompanyList;
        public ArrayList CompanyList;
        public int ArrayIndex = 0;

        public UsingArrayList(int Number)
        {
            CompaniesDict = new Dictionary<string, Company>();
            //CompanyList = new string[2 * Number];
            CompanyList = new ArrayList();
        }

        public void AddCompany(string CompanyName, int EmpWagePerhour, int FullTime_WorkingHrs_PerDay, int PartTime_WorkingHours_PerDay, int MAX_WORKING_HRS, int MAX_WORKING_DAYS)
        {
            Company company = new Company(CompanyName.ToLower(), EmpWagePerhour, FullTime_WorkingHrs_PerDay, PartTime_WorkingHours_PerDay, MAX_WORKING_HRS, MAX_WORKING_DAYS);
            CompaniesDict.Add(CompanyName.ToLower(), company);
            //CompanyList[ArrayIndex] = CompanyName;
            CompanyList.Add(CompanyName);
            //CompanyList.Add(EmpWagePerhour * FullTime_WorkingHrs_PerDay);

            ArrayIndex++;
        }

        public int IsEmployeePresent()
        {
            return new Random().Next(0, 3);
        }

        public void CalculateEmpWage(string CompanyName)
        {
            int hourPerDay = 0;
            float wagePerDay = 0;
            int totalWorkingHrs = 0;
            int presentDays = 0;
            float monthlyWage = 0;


            if (!CompaniesDict.ContainsKey(CompanyName.ToLower()))
                throw new ArgumentNullException("Company Don't Exist");
            CompaniesDict.TryGetValue(CompanyName.ToLower(), out Company company);



            while (totalWorkingHrs < company.MAX_WORKING_HRS && presentDays < company.MAX_WORKING_DAYS)
            {

                switch (IsEmployeePresent())
                {
                    case IS_FULL_TIME:
                        hourPerDay = company.FullTime_WorkingHrs_PerDay;
                        presentDays++;
                        break;
                    case IS_PART_TIME:
                        hourPerDay = company.PartTime_WorkingHours_PerDay;
                        presentDays++;
                        break;
                    default:
                        hourPerDay = 0;
                        break;

                }
                totalWorkingHrs += hourPerDay;
                wagePerDay = (company.EmpWagePerHour * hourPerDay);
                monthlyWage += wagePerDay;

            }
            //CompanyList[ArrayIndex] = Convert.ToString(monthlyWage);
            //ArrayIndex++;
            CompanyList.Add(monthlyWage);

        }
        public void displayArray()
        {
            for (int i = 0; i < CompanyList.Count; i += 2)
            {
                Console.WriteLine("Monthly wage for {0} is {1}", CompanyList[i], CompanyList[i + 1]);
            }
        }
    }
}
