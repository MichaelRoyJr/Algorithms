using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5_2
{
    class MonthTest
    {
        static void Main(string[] args)
        {
            int month;
            Console.Write("Enter a number for a month: ");
            month = int.Parse(Console.ReadLine());
            if (month < 13)
            {
                if (month > 0)
                {
                    Month testMonth = new Month();
                    testMonth.MonthNumber = month;
                    Console.WriteLine("The value " + month + " corresponds to " + testMonth.GetMonthName() + " which has " + testMonth.GetNumberOfDays() + " days.");
                }
                else
                    Console.WriteLine("Value entered is outside of range!");
            }
            else
                Console.WriteLine("Value entered is outside of range!");            
        }
    }
}
