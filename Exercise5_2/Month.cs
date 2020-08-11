using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5_2
{
    class Month
    {
        private int monthNumber;

        public int MonthNumber
        {
            get
            {
                return monthNumber;
            }
            set
            {
                monthNumber = value;
            }
        }


        public string GetMonthName()
        {
            switch(monthNumber)
            {
                case 1:
                    return "January";
                case 2:
                    return "February";
                case 3:
                    return "March";
                case 4:
                    return "April";
                case 5:
                    return "May";
                case 6:
                    return "June";
                case 7:
                    return "July";
                case 8:
                    return "August";
                case 9:
                    return "September";
                case 10:
                    return "October";
                case 11:
                    return "November";
                default:
                    return "December";
            }
        }

        public int GetNumberOfDays()
        {
            switch(monthNumber)
            {
                case 2:
                    return 28;
                case 4:
                case 6:
                case 9:
                case 11:
                    return 30;
                default:
                    return 31;                
            }
        }

        public override string ToString()
        {
            return GetMonthName() + " has " + GetNumberOfDays().ToString() + " days.";
        }
    }
}
