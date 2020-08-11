using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Exercise13_1
{
    class CurrentDirectory
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Current Directory: " + Directory.GetCurrentDirectory() + "\n");
            Console.WriteLine("File Name".PadRight(50) + "Size\n");
            DirectoryInfo dir = new DirectoryInfo(".");
            foreach (FileInfo file in dir.GetFiles("*.*"))
            {
                Console.WriteLine("{0}{1}", file.Name.PadRight(50), file.Length);

            }
        }
    }
}
