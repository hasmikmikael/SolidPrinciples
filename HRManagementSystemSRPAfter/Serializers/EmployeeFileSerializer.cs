using HRManagementSystemSRPAfter.Employees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManagementSystemSRPAfter.Serializers
{
    public class EmployeeFileSerializer
    {
        public string Serialize(Employee employee)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"### EMPLOYEE RECORD ### {Environment.NewLine}");
            sb.Append($"NAME: ");
            sb.Append($"{employee.GetFullName()} {Environment.NewLine}");
            sb.Append("POSITION: ");
            sb.Append($"{employee.GetType().Name} {Environment.NewLine}");
            sb.Append("EMAIL: ");
            sb.Append($"{employee.GetEmail()} {Environment.NewLine}");
            sb.Append("MONTHLY WAGE: ");
            sb.Append($"{employee.GetMonthlyIncome()} {Environment.NewLine}");

            return sb.ToString();
        }
    }
}
