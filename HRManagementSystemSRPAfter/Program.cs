using HRManagementSystemSRPAfter.Employees;
using HRManagementSystemSRPAfter.Loggers;
using HRManagementSystemSRPAfter.Repository;

namespace HRManagementSystemSRPAfter
{
    class Program
    {
        public static void Main(string[] args) 
        {
            //Grab employee
            EmployeeRepository repository = new EmployeeRepository();
            List<Employee> employees = repository.FindAll();

            ConsoleLogger consoleLogger = new ConsoleLogger();

            //Save all
            foreach (var employee in employees)
            {
                try
                {
                    repository.Save(employee);
                    ConsoleLogger.WriteInfo($"Saved employee {employee.ToString()}");
                }
                catch (Exception ex)
                {

                    ConsoleLogger.WriteError($"Error saving employee", ex);
                }
            }
        }
    }
}