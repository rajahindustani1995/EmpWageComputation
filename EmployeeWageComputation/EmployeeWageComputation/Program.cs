namespace EmployeeWageComputation
{

    class program
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program");
            SwitchCase switchCase = new SwitchCase();
            switchCase.CalculateWage();
        }
    }
}