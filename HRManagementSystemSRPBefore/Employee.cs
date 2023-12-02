using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManagementSystemSRPBefore
{
    public abstract class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int MonthlyIncome { get; set; }
        public int NbHoursPerWeek { get; set; }

        public Employee(string fullName, int monthlyIncome)
        {
            SetMonthlyIncome(monthlyIncome);

            string[] names = fullName.Split(" ");
            FirstName = names[0];
            LastName = names[1];
        }

        public string GetEmail()
        {
            return $"{FirstName}.{LastName}@gmail.com";
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName} - {MonthlyIncome}";
        }

        public int GetMonthlyIncome()
        {
            return MonthlyIncome;
        }

        public void SetMonthlyIncome(int monthlyIncome)
        {
            if (monthlyIncome < 0)
            {
                throw new ArgumentException("Income must be positive");
            }

            MonthlyIncome = monthlyIncome;
        }

        public int GetNbHoursPerWeek()
        {
            return NbHoursPerWeek;
        }

        public void SetNbHoursPerWeek(int nbHoursPerWeek)
        {
            if (nbHoursPerWeek <= 0)
            {
                throw new ArgumentException("Hours must be positive");
            }

            NbHoursPerWeek = nbHoursPerWeek;
        }

        public string GetFullName()
        {
            return $"{FirstName} {LastName}";
        }

        public static void Save(Employee employee)
        {
            try
            {
                StringBuilder sb = new StringBuilder();
                sb.Append($"### EMPLOYEE RECORD ### {Environment.NewLine}");
                sb.Append($"NAME: ");
                sb.Append($"{employee.FirstName} {employee.LastName} {Environment.NewLine}");
                sb.Append("POSITION: ");
                sb.Append($"{employee.GetType().Name} {Environment.NewLine}");
                sb.Append("EMAIL: ");
                sb.Append($"{employee.GetEmail()} {Environment.NewLine}");
                sb.Append("MONTHLY WAGE: ");
                sb.Append($"{employee.MonthlyIncome} {Environment.NewLine}");

                string workingDirectory = Environment.CurrentDirectory;
                string projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName;

                //string path = Path.GetFullPath($"{employee.GetFullName().Replace(" ", "_")} .txt");
                string path = $"{projectDirectory}\\Files\\{employee.GetFullName().Replace(" ", "_")}.txt";

                File.WriteAllText(path, sb.ToString());

                Console.WriteLine($"Saved employee {employee.ToString()}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"ERROR: Could not save employee. {ex}");
            }
        }


        //public string Name { get; set; }
        //public string Email { get; set; }
        //public void Save()
        //{
        //    string fileName = @"D:\text.txt";

        //    using (FileStream fileStream = File.Create(fileName))
        //    {
        //        byte[] bytes = new UTF8Encoding(true).GetBytes("New text");
        //        fileStream.Write(bytes);
        //    }
        //}
    }
}
