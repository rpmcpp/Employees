using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    abstract partial class Employee
    {
        
        // METHODS ------------------------------------------------------------------------------------
        
        public void DisplayStatus()
        {
            Console.WriteLine("Name: {0}", empName);
            Console.WriteLine("Position: {0}", this.GetType());
            Console.WriteLine("ID: {0}", empID);
            Console.WriteLine("Age: {0}", empAge);
            Console.WriteLine("SSN: {0}", socSecNum);
            Console.WriteLine("Pay: {0}", currPay);
            Console.WriteLine("Bonus: {0}", bonus);
        }

        public double GetBenefitCost()
        {
            return EmpBenefits.ComputePayDeduction();
        }

        public virtual void GiveBonus(float amount)
        {
            bonus = amount;
        }

       // static void GivePromotion(Employee emp)                   // Later
        //{                                                         // Later
            // Increase pay and give parking space                  // Later
          //  Console.WriteLine("{0} was promoted!", emp.Name);     // Later
        //}



        // PROPERTIES -----------------------------------------------------------------------------------
        
        public string Name
        {
            get { return empName;}
            set
            {
                if (value.Length > 15)
                    Console.WriteLine("Error! Name must be less than 16 characters!");
                else
                    empName = value;
            }
        }

        public string SSN
        {
            get { return socSecNum; }
            set { socSecNum = value; }
        }

        public int ID
        {
            get { return empID; }
            set { empID = value; }      // 'set' scope uses the token 'valie' to rep incoming
        }                               // value assigned to the property (a contectual keyword)

        public int Age
        {
            get { return empAge; }
            set { empAge = value; }
        }

        public float Pay
        {
            get { return currPay;}
            set { currPay = value; }
        }

        public float Bonus
        {
            get { return bonus; }
        }

        public BenefitPackage Benefits
        {
            get { return EmpBenefits;}
            set { EmpBenefits = value; }
        }

        // NESTED CLASS -------------------------------------------------------------------------------

        public class EdReimbursement
        {
            public enum ReimburseRate
            {
                College = 50, Cert = 75
            }
            
            // FIELD DATA =============================================================================

            private double collTuition;
            private double certFees;
            public double reimbursement;


            // CTORs ==================================================================================

            public EdReimbursement(){}

            // METHODS ================================================================================

            public double CalcReimburse (Enum ed, double amt)
            {
                switch (ed.ToString())
                {
                    case "College":
                        reimbursement = ((double)ReimburseRate.College / 100) * amt;
                        break;
                    case "Cert":
                        reimbursement = ((double)ReimburseRate.Cert / 100) * amt;
                        break;
                    default:
                        Console.WriteLine("Reimbursement rate not set");
                        break;
                }
                return reimbursement;

            }

            // PROPERTIES =============================================================================

            public double CollTuition
            {
                get { return collTuition; }
                set { collTuition = value; }
            }

            public double CertFees
            {
                get { return certFees;}
                set { certFees = value; }
            }


        }

        // OLD METHODS ----------------------------------------------------------
        
        // Accessor (get method)
        //public string GetName()
        //{
        //    return empName;
        //}

        // Mutator (set method)
        //public void SetName(string name)
        //{
        // Check incoming value
        //    if (name.Length > 15)
        //        Console.WriteLine("Error! Name must be less than 16 characters!");
        //    else
        //       empName = name;
        //public void GiveBonus(float amount)
        //{
        //    currPay += amount;
        //}
        //}
    }
}
