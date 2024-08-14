using System.Xml.Linq;
using System;


namespace project6
    {
        internal class Program
        {
            static void Main(string[] args)
            {
            Contract contract = new Contract();
            contract.employee();
            Payroll payroll = new Payroll();
            payroll.Employees();
               }
        }
    }

