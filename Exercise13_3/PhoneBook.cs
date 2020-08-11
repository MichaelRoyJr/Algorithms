using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Exercise13_3
{
    class PhoneBook
    {
        static void Main(string[] args)
        {
            string name,
                address,
                phoneNumber;
            bool play = true;

            while (play)
            {
                try
                {
                    StreamWriter outFile = new StreamWriter("PhoneBook.txt", true);
                    string output = "";
                    Console.Write("Enter Name: ");
                    name = Console.ReadLine();
                    Console.Write("Enter Address: ");
                    address = Console.ReadLine();
                    Console.Write("Enter Phone Number (xxx-xx-xxxx): ");
                    phoneNumber = Console.ReadLine();

                    output += name + "\n" + address + "\n*" + phoneNumber.Substring(0, 3) + phoneNumber.Substring(4, 3) + phoneNumber.Substring(8, 4) + "*\n";

                    outFile.WriteLine(output);
                    outFile.Close();

                    Console.Clear();
                    Console.WriteLine("Entry stored!");
                    Console.Write("Would you like to enter more contacts (Y / N)? ");
                    char answer = (char)Console.Read();
                    if (answer == 'N' || answer == 'n')
                        play = false;


                }

                catch (System.IO.IOException ex)
                {
                    Console.Error.WriteLine(ex.Message);
                }
            }
            
        }
    }
}
