using System;

namespace project6
{
    internal class Payroll
    {
        public void Employees()
        {
            Console.WriteLine("Enter your employee type (on payroll):");
            var employeeType = Console.ReadLine();

            if (employeeType == "on payroll")
            {
                Console.WriteLine("Enter the employee id:");
                int id = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the employee name:");
                string name = Console.ReadLine();

                Console.WriteLine("Enter the reporting manager name:");
                string manager = Console.ReadLine();

                Console.WriteLine("Enter employee joining date:");
                DateOnly joiningDate =DateOnly.Parse( Console.ReadLine());

                Console.WriteLine("Enter employee experience (in years):");
                int exp = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter employee basic salary:");
                int basicSalary = int.Parse(Console.ReadLine());

                double DA = 0, HRA = 0, PF = 0;

                if (exp > 10)
                {
                    DA = basicSalary * 0.10;
                    HRA = basicSalary * 0.085;
                    PF = 6200;
                }
                else if (exp > 7 && exp <= 10)
                {
                    DA = basicSalary * 0.07;
                    HRA = basicSalary * 0.065;
                    PF = 4100;
                }
                else if (exp > 5 && exp <= 7)
                {
                    DA = basicSalary * 0.041;
                    HRA = basicSalary * 0.038;
                    PF = 1800;
                }
                else if (exp <= 5)
                {
                    DA = basicSalary * 0.019;
                    HRA = basicSalary * 0.020;
                    PF = 1200;
                }

                double totalSalary = basicSalary + DA + HRA + PF;

                Console.WriteLine($"DA: {DA}, HRA: {HRA}, PF: {PF}");
                Console.WriteLine($"Employee id: {id}\nEmployee name: {name}\nReporting manager name: {manager}\nJoining Date: {joiningDate}\nExperience: {exp} years\nTotal Salary: {totalSalary}");
            }
            else
            {
                Console.WriteLine("Invalid employee type. Please enter  'on payroll'.");
            }
        }
    }
}
