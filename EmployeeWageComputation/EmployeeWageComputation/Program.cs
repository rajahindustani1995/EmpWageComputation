namespace EmployeeWageComputation
{

    class program
    {
        public static void Main(String[] args)
        {

            Console.WriteLine("Welcome to Employee Wage Computation Program");           
            
            UsingArrayList usingArrayList  = new UsingArrayList(2);
            usingArrayList.AddCompany("Jeep", 20, 8, 4, 100, 20);
            usingArrayList.CalculateEmpWage("Jeep");

            usingArrayList.AddCompany("TATA", 30, 8, 4, 100, 20);
            usingArrayList.CalculateEmpWage("TATA");


            usingArrayList.displayArray();
        }
    } 
}