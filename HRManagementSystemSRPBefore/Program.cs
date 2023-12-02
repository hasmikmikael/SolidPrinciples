namespace HRManagementSystemSRPBefore
{
    class Program
    {
        static void Main(string[] args)
        {
            //Grab employees
            EmployeeRepository repository = new EmployeeRepository();
            List<Employee> employees = repository.FindAll();

            //Save all
            foreach (var employee in employees)
            {
                Employee.Save(employee);
            }



            //Console.WriteLine("*** Solid Principles Demo ***");

            //Employee emp = new FullTimeEmployee();
            //emp.Save();
        }
    }
}
