using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    class BenefitPackage
    {

        // FIELD DATA ---------------------------------------------------------------------------------

        private float totalCost;
        private float empShare;
        private float coShare;

        // CTORs --------------------------------------------------------------------------------------

        public BenefitPackage(){}

        // METHODS ------------------------------------------------------------------------------------

        public double ComputePayDeduction()
        {
            return empShare;
        }

        // PROPERTIES ---------------------------------------------------------------------------------

        public float TotalCost
        {
            set { totalCost = value; }
        }

        public float EmpShare
        {
            set { empShare = value; }
        }

        public float CoShare
        {
            get
            {
                coShare = totalCost - empShare;
                return coShare;
            }
        }
        
    }
}