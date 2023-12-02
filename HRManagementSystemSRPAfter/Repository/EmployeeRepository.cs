using HRManagementSystemSRPAfter.Employees;
using HRManagementSystemSRPAfter.Serializers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManagementSystemSRPAfter.Repository
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

        public void Save(Employee employee)
        {
            EmployeeFileSerializer employeeFileSerializer = new EmployeeFileSerializer();
            string employeeSerialized = employeeFileSerializer.Serialize(employee);

            string workingDirectory = Environment.CurrentDirectory;
            string projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName;

            string path = $"{projectDirectory}\\Files\\{employee.GetFullName().Replace(" ", "_")}.txt";

            File.WriteAllText(path, employeeSerialized);
        }
    }
}
