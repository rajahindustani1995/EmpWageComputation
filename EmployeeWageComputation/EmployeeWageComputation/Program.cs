namespace EmployeeWageComputation
{

    class program
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program");
            EmployeeAttendance prg = new EmployeeAttendance();
            prg.CheckEmpPresentAbsent();
        }
    }
}