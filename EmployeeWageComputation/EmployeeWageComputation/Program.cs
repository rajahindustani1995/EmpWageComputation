namespace EmployeeWageComputation
{

    class program
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program");
            MonthlyWageFor100hrs monthlyWageFor100Hrs = new MonthlyWageFor100hrs();
            monthlyWageFor100Hrs.CalculateEmpMonthlyWage();
        }
    }
}