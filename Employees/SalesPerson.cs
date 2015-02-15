using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    class SalesPerson : Employee
    {
        // FIELD DATA ---------------------------------------------------------------------------------

        public int SalesNumber { get; set; }
        private double edReimbursement;
        private Employee.EdReimbursement tuitionRe;                 // To access inner class
        private Employee.EdReimbursement.ReimburseRate salesEdRate;    // of Employee

        // CTORs --------------------------------------------------------------------------------------
        public SalesPerson(){}
        public SalesPerson(string fullName, string ssn, int empID, int age, float currPay, int numOfSales)
            : base(fullName, ssn, empID, age, currPay)
        {
            SalesNumber = numOfSales;
        }

        // METHODS ------------------------------------------------------------------------------------

        public override sealed void GiveBonus(float amount) // sealed, no PT bonus!
        {
            int salesBonus = 0;
            if (SalesNumber >= 0 && SalesNumber <= 100)
            {
                salesBonus = 10;
            }
            else if (SalesNumber >= 101 && SalesNumber <=200)
            {
                salesBonus = 15;
            }
            else
            {
                salesBonus = 20;
            }
            base.GiveBonus(amount * salesBonus);
        }

        public new void DisplayStatus()
        {
            base.DisplayStatus();
            Console.WriteLine("Number of Sales: {0}", SalesNumber);
            Console.WriteLine("Benefit Deduction: {0:c2}", Benefits.ComputePayDeduction());
            Console.WriteLine("Educational Reimbursement: {0}", EdReimburse);
            Console.WriteLine("Educational activity: {0}", SalesEdRate.ToString());
        }


        // PROPERTIES ---------------------------------------------------------------------------------

        public Employee.EdReimbursement TuitionRe
        {
            get { return tuitionRe; }
        }

        public Employee.EdReimbursement.ReimburseRate SalesEdRate
        {
            get { return salesEdRate; }
        }

        public double EdReimburse
        {
            get
            {
                tuitionRe = new Employee.EdReimbursement();         // instantiate parent
                salesEdRate =                                       // inner class
                    Employee.EdReimbursement.ReimburseRate.Cert;    //
                edReimbursement = TuitionRe.CalcReimburse(SalesEdRate, 8000.00);
                return edReimbursement;
            }
        }

    }
}
