namespace EmployeeWageComputation
{

    class program
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program");           
            
            EmpWageArray empWageBuilder = new EmpWageArray();

            //Passing values to AddCompanyEmpWage method for further calculation
            empWageBuilder.AddCompanyEmpWage("JEEP", 32, 22, 110);
            empWageBuilder.AddCompanyEmpWage("TATA", 38, 20, 100);

            empWageBuilder.ComputeEmpWage();
        }
    } 
}