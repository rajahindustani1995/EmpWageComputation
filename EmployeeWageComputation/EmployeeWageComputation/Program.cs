namespace EmployeeWageComputation
{

    class program
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program");
            EmpDailyWage obj = new EmpDailyWage();
            obj.DailyWage();
        }
    }
}