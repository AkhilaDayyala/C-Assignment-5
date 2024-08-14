using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project6
{
    internal class Contract
    {
        public void employee()
        {
            Console.WriteLine("enter your employee type(Contract basis)");
           var employeeType=Console.ReadLine();

            if (employeeType == "Contract basis")
            {
                Console.WriteLine("Enter the employee id:");
                string id = Console.ReadLine();

                Console.WriteLine("Enter the employee name:");
                string name = Console.ReadLine();

                Console.WriteLine("Enter the manager name:");
                string manager = Console.ReadLine();

                Console.WriteLine("Enter contract date:");
                string contractDate = Console.ReadLine();

                Console.WriteLine("Enter employee duration:");
                string duration = Console.ReadLine();

                Console.WriteLine("Enter employee charges:");
                string charges = Console.ReadLine();
                Console.WriteLine("employee id:" + id + "\n" + "employee name:" + name + "\n" + "Reporting manager name:" + manager + "\n" + "contact Date:" + contractDate + "\n" + "duration:" + duration + "\n" + "charges:" + charges);
            }
            else {
                Console.WriteLine("enter your valid employee type");

            }


        }
        }
}
