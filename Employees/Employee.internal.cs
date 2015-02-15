using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    abstract partial class Employee
    {
        // FIELD DATA ---------------------------------------------------------------------------------
        
        private string empName;
        private int empID;
        private int empAge;
        private string socSecNum;
        private float currPay;
        private float bonus;
        // contains
        protected BenefitPackage EmpBenefits = new BenefitPackage();



        // ctors --------------------------------------------------------------------------------------
        
        public Employee() { }
        public Employee(String name, string ssn)                                // ctor chained
            : this(name, ssn, 000, 21, 0.0f) { }
        public Employee(String name, string ssn, int id)                        // ctor chained
            : this(name, ssn, id, 21, 0.0f) { }
        public Employee(string name, string ssn, int id, int age, float pay)    // master ctor
        {
            Name = name;        // Using properties for assignments in ctor
            Age = age;          // centralize data validation
            ID = id;
            Pay = pay;
            SSN = ssn;    
        }
     }
}
