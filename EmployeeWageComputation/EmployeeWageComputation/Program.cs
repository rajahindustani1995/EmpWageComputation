namespace EmployeeWageComputation
{

    class program
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program");

            MultipleCompany multipleCompany = new MultipleCompany(2);
            multipleCompany.AddCompany("Jeep", 20, 8, 4, 100, 20);
            multipleCompany.CalculateEmpWage("Jeep");

            multipleCompany.AddCompany("TATA", 30, 8, 4, 100, 20);
            multipleCompany.CalculateEmpWage("TATA");

            multipleCompany.displayArray();
        }
    } 
}