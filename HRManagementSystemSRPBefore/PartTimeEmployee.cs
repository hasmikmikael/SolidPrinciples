using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManagementSystemSRPBefore
{
    public class PartTimeEmployee : Employee
    {
        public PartTimeEmployee(string fullName, int monthlyIncome) : base(fullName, monthlyIncome)
        {
            SetNbHoursPerWeek(20);
        }

        //public override void Save()
        //{
        //    Console.WriteLine("Save PTE files.");
        //}
    }
}
