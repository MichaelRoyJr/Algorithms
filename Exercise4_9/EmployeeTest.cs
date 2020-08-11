using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4_9
{
    class EmployeeTest
    {
        static void Main(string[] args)
        {
            string employeeName;
            double salesAmount;
            double netPay;

            Console.Write("Please enter employee name: ");
            employeeName = Console.ReadLine();
            Console.Write("Please enter weekly sales amount: ");
            salesAmount = double.Parse(Console.ReadLine());

            Employee testEmployeeA = new Employee();
            testEmployeeA.SetName(employeeName);
            testEmployeeA.Sales = salesAmount;
            netPay  = testEmployeeA.CalculateCommission() - testEmployeeA.CalculateFederalWithholding() - testEmployeeA.CalculateRetirementContribution() - testEmployeeA.CalculateSocSecWithholding();

            
            Console.WriteLine("\nEmployee, " + testEmployeeA.GetName() + ", sold {0:C} and earned {1:C}.", testEmployeeA.Sales, testEmployeeA.CalculateCommission());
            Console.WriteLine("{0:C} was withheld for federal taxes.", testEmployeeA.CalculateFederalWithholding());
            Console.WriteLine("{0:C} was withheld for Social Security taxes.", testEmployeeA.CalculateSocSecWithholding());
            Console.WriteLine("{0:C} was withheld for retirement contributions.", testEmployeeA.CalculateRetirementContribution());
            Console.WriteLine("Leaving a net paycheck of: {0:C}", netPay);
            Console.WriteLine();

            Employee testEmployeeB = new Employee(employeeName, salesAmount);
            netPay = testEmployeeB.CalculateCommission() - testEmployeeB.CalculateFederalWithholding() - testEmployeeB.CalculateRetirementContribution() - testEmployeeB.CalculateSocSecWithholding();

            Console.WriteLine("Employee " + testEmployeeB.GetName() + " sold {0:C} and earned {1:C}.", testEmployeeB.Sales, testEmployeeB.CalculateCommission());
            Console.WriteLine("{0:C} was withheld for federal taxes.", testEmployeeB.CalculateFederalWithholding());
            Console.WriteLine("{0:C} was withheld for Social Security taxes.", testEmployeeB.CalculateSocSecWithholding());
            Console.WriteLine("{0:C} was withheld for retirement contributions.", testEmployeeB.CalculateRetirementContribution());
            Console.WriteLine("Leaving a net paycheck of: {0:C}", netPay);
        }
    }
}
