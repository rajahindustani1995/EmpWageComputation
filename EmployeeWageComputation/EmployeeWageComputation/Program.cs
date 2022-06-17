namespace EmployeeWageComputation
{

    class program
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program");
            SaveWageForEachCompany save = new SaveWageForEachCompany();
            save.SaveForEachCompany();

        }
    } 
}