using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4_9
{
    class Employee
    {
        private int commission;
        private double sales;
        private string name;
        private const int FED_TAX = 18;
        private const int RETIREMENT = 10;
        private const int SOC_SEC_TAX = 6;

        public Employee()
        {
            commission = 7;
        }

        public Employee(string employeeName, double salesAmount)
        {
            name = employeeName;
            sales = salesAmount;
            commission = 7;
        }

        public Employee(string employeeName, double salesAmount, int commissionRate)
        {
            name = employeeName;
            sales = salesAmount;
            commission = commissionRate;
        }

        public string GetName()
        {
            return name;
        }

        public void SetName(string newName)
        {
            name = newName;
        }
       
        public int Commission
        {
            get
            {
                return commission;
            }
            set
            {
                commission = value;
            }
        }

        public double Sales
        {
            get
            {
                return sales;
            }
            set
            {
                sales = value;
            }
        }

        public double CalculateCommission()
        {
            return  sales * commission / 100; 
        }

        public double CalculateFederalWithholding()
        {
            return sales * commission * FED_TAX / 10000;
        }

        public double CalculateSocSecWithholding()
        {
            return sales * commission * SOC_SEC_TAX / 10000;
        }

        public double CalculateRetirementContribution()
        {
            return sales * commission * RETIREMENT / 10000;
        }
    }
}
