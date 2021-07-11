
/*Test Code/ Snippets: 
    Double Var. Name = Convert.ToDouble(Console.ReadLine());

foreach (UserInputLength);
        if (Double.TryParse();
        else Console.WriteLine("Unable to calculate please try again using only numbers.", value);

 */

using System;

namespace Flooring_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello This is a Flooring Calculator");
            Console.WriteLine("You can calculate your flooring cost with this program");
            // Code Step 1: Enter the Length x Width x Cost of flooring
         //How to change code to limit readline input to doubles only?
            //Code Step 2: Convert string values to doubles -- done by creating double with string input conversion
            Console.WriteLine("We will start by entering the L x W x Unit Cost of the flooring you'd like to use");
            
            Console.WriteLine("Enter the length");
            Double OutputLength = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the width");
            Double OutputWidth = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the flooring unit cost");
            Double OutputFlooringUnitCost = Convert.ToDouble(Console.ReadLine());


            //Code Step 3: Calculates the Total Cost of Flooring = L x W x Unit Cost
            //Need to calculate "double" OutputLength x OutputWidth x OutputFLooringUnitCost
            Double TotalCostofFlooring = OutputLength * OutputWidth * OutputFlooringUnitCost;

         //Code Step 4: Display Output
                Console.WriteLine("The cost of your flooring is $" + TotalCostofFlooring);
        }
    }
}
