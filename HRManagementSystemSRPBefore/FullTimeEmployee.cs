using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManagementSystemSRPBefore
{
    public class FullTimeEmployee : Employee
    {
        public FullTimeEmployee(string fullName, int monthlyIncome) : base(fullName, monthlyIncome)
        {
            SetNbHoursPerWeek(40);
        }

        //public override void Save()
        //{
        //    Console.WriteLine("Save FTE files.");
        //}
    }
}
