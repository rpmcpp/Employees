using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** The Employee Class Hierarchy *****\n");

            SalesPerson fred = new SalesPerson();
            fred.Age = 31;
            fred.Name = "Fred";
            fred.SalesNumber = 50;
            fred.GiveBonus(1.0f);
            fred.DisplayStatus();
            Console.ReadLine();

            Manager chuck = new Manager("Chuck", "123-456-7890", 999, 50, 25.00f, 150);
            chuck.Benefits.TotalCost = 650.25f;
            chuck.Benefits.EmpShare = 390.15f;
            chuck.GiveBonus(2.0f);
            chuck.DisplayStatus();
            Console.ReadLine();

            PTSalesPerson bambi = new PTSalesPerson("Bambi", "169-69-6969", 169, 27, 15.00f, 269, 24);
            bambi.Benefits.TotalCost = 212.75f;
            bambi.Benefits.EmpShare = 212.75f;
            bambi.GiveBonus(1.5f);
            bambi.DisplayStatus();
            Console.ReadLine();

            // Playing with Base Class / Derived Class casting rules

            object frank = new Manager("Frank Zappa", "111-222-3333", 666, 55,  5.00f, 10);

            // Can't skip a level in parent-child relation in declaration
            //Employee moonUnit = new PTSalesPerson("MoonUnit", "999-888-7777", 555, 32, 9.00, 42, 24 );
            //GivePromotion(moonUnit);

            // THis instead
            Employee moonUnit = new Manager("MoonUnit", "999-888-7777", 555, 24, 9.00f, 5);
            GivePromotion(moonUnit);
            
            // Or this
            SalesPerson jill = new PTSalesPerson("Jill", "444-555-6666", 654, 36, 14.00f, 31, 24);
            GivePromotion(jill);

            // No-Go, an object is not an Employee
            //GivePromotion(frank);

            //This instead, cast as Manager
            GivePromotion((Manager)frank);
            
            Console.ReadLine();

            // Can only cast in obbjects hierarchy
            //No-Go
            //Hexagon hex = (Hexagon) frank;
            // To test
            //Hexagon hex = frank as Hexagon;
            //if (hex == null)
            //{
            //    Console.WriteLine("frank's not a Hexagon");
            //}
            // or to test true or false if "is" a type
            //if(emp is SalesPerson
            // ... See GivePromotion



        }


        // METHODS ----------------------------------------------------------------------------------

        private static void GivePromotion(Employee emp)
        {
            // Increase pay and give parking space
            Console.WriteLine("{0} was promoted!", emp.Name);

            if (emp is SalesPerson)
            {
                Console.WriteLine("{0} made {1} sales!", emp.Name, ((SalesPerson)emp).SalesNumber);
                Console.WriteLine();
            }
            if (emp is Manager)
            {
                Console.WriteLine("{0} has {1} stock options . . .", emp.Name, ((Manager)emp).StockOptions);
                Console.WriteLine();
            }
            Console.ReadLine();

        }
    }
}
