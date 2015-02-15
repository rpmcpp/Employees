using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    class Manager : Employee
    {
        // FIELD DATA ---------------------------------------------------------------------------------

        public int StockOptions { get; set; }
        private double edReimbursement;
        private Employee.EdReimbursement tuitionRe;                 // To access inner class
        private Employee.EdReimbursement.ReimburseRate mgrEdRate;    // of Employee

        // CTORs --------------------------------------------------------------------------------------

        public Manager(){}
        public Manager(string fullName, string ssn, int empID, int age, float currPay, int numOfOpts)
            : base(fullName, ssn, empID, age, currPay)
        {
            // This field defined in Manager
            StockOptions = numOfOpts;
        }

        // METHODS ------------------------------------------------------------------------------------

        public new void DisplayStatus()
        {
            base.DisplayStatus();
            Console.WriteLine("Stock Options: {0}", StockOptions);
            Console.WriteLine("Benefit Deduction: {0:c2}", Benefits.ComputePayDeduction());
            Console.WriteLine("Educational Reimbursement: {0}", EdReimburse);
            Console.WriteLine("Educational activity: {0}", mgrEdRate.ToString());
        }

        public override void GiveBonus(float amount)
        {
            base.GiveBonus(amount);
            Random r = new Random();
            StockOptions += r.Next(500);
        }


        // PROPERITES ---------------------------------------------------------------------------------

        public Employee.EdReimbursement TuitionRe
        {
            get { return tuitionRe;}
        }

        public Employee.EdReimbursement.ReimburseRate MgrEdRate
        {
            get { return mgrEdRate;}
        }

        public double EdReimburse
        {
            get
            {
                tuitionRe = new Employee.EdReimbursement();             // instantiate parent
                mgrEdRate =                                             // inner class
                    Employee.EdReimbursement.ReimburseRate.College;     //
                edReimbursement = TuitionRe.CalcReimburse(MgrEdRate, 12000.00);
                return edReimbursement;
            }
        }

    }
}
