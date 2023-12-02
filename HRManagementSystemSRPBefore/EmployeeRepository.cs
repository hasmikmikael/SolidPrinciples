using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManagementSystemSRPBefore
{
    public class EmployeeRepository
    {
        public List<Employee> FindAll()
        {
            //Employees are kept in memory for simplicity
            Employee anna = new FullTimeEmployee("Anna Smith", 2000);
            Employee billy = new FullTimeEmployee("Billy Leech", 920);

            Employee steve = new PartTimeEmployee("Steve Jones", 800);
            Employee magda = new PartTimeEmployee("Magda Iovan", 920);

            List<Employee> employees = new();
            employees.Add(anna);
            employees.Add(billy);
            employees.Add(steve);
            employees.Add(magda);

            return employees;
        }
    }
}
