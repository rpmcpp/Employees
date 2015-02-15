using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Employees
{
    sealed class PTSalesPerson : SalesPerson
    {
        // FIELD DATA ---------------------------------------------------------------------------------

        private int maxHrs;


        //CTORs ---------------------------------------------------------------------------------------

        public PTSalesPerson(string fullName, string ssn, int empID, int age, float currPay, int numSales, int maxHours)
            : base(fullName, ssn, empID, age, currPay, numSales) 
        {
            maxHrs = maxHours;
        }

        // METHODS ------------------------------------------------------------------------------------

        public new void DisplayStatus()
        {
            Console.WriteLine("Name: {0}", Name);
            Console.WriteLine("ID: {0}", ID);
            Console.WriteLine("Age: {0}", Age);
            Console.WriteLine("SSN: {0}", SSN);
            Console.WriteLine("Pay: {0}", Pay);
            Console.WriteLine("Bonus: {0}", Bonus);
            Console.WriteLine("Number of Sales: {0}", SalesNumber);
            Console.WriteLine("Benefit Deduction: PT: Not eligible for benefits.");
            Console.WriteLine("Educational Reimbursement: PT: Not eligible for Ed Reimbursement.");
        }
    }
}
