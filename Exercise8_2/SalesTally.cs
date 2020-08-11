using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise8_2
{
    class SalesTally
    {
        static void GetSales(double[,] sales, string[] salesman, string[] product)
        {
            string name, sale, productName;
            double saleAmount;
            int productNumber, salesmanNumber;
            bool more = true;

            while (more)
            {
                //Prompt for all values
                Console.WriteLine("'quit' to quit");
                Console.Write("Enter salesman name: ");
                name = Console.ReadLine();
                if (name != "quit")
                {
                    Console.Write("Enter sale amount: ");
                    sale = Console.ReadLine();
                    Console.Write("Enter product: ");
                    productName = Console.ReadLine();

                    saleAmount = double.Parse(sale);

                    productNumber = FindProduct(productName, product);
                    salesmanNumber = FindSalesman(name, salesman);
                    sales[salesmanNumber, productNumber] += saleAmount;
                    Console.Clear();
                }
                else
                    more = false;
            }
        }

        static int FindSalesman(string name, string[] salesman)
        {
            for (int i=0; i < salesman.Length; i++)
            {
                if (name == salesman[i])
                    return i;
            }
            return -1;

        }

        static int FindProduct(string productName, string[] product)
        {
            for (int i=0; i < product.Length; i++)
            {
                if (productName == product[i])
                    return i;
            }
            return -1;
        }

        static void DisplayHeaders(double[,] sales, string[] product)
        {
            Console.Write("{0,-20}" , "Salesman");
            for (int i=0; i < sales.GetLength(1); i++)
            {
                Console.Write("{0, 12}", product[i]);
            }
            Console.WriteLine();
        }

        static void DisplayReport(double[,] sales, string[] salesman)
        {
            for (int i=0; i < sales.GetLength(0); i++)
            {
                Console.Write("{0,-20}", salesman[i]);
                for (int j=0; j < sales.GetLength(1); j++)
                {
                    Console.Write("{0, 12:C2}", sales[i, j]);
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            double[,] sales = new double[3, 5];
            string[] salesman = { "Mike Roy", "Rachael Roy", "Abraham Lincoln" };
            string[] product = { "bath towel", "toothbrush", "pliers", "coffee pot", "ice cream" };

            GetSales(sales, salesman, product);
            Console.Clear();
            DisplayHeaders(sales, product);
            DisplayReport(sales, salesman);
        }
    }
}
