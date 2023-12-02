using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManagementSystemSRPAfter.Employees
{
    public class FullTimeEmployee : Employee
    {
        public FullTimeEmployee(string fullName, int monthlyIncome) : base(fullName, monthlyIncome)
        {
            SetNbHoursPerWeek(40);
        }
    }
}
