using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise8_8
{
    class PigLatin
    {
        public static string Translate(string item)
        {
            if (IsVowel(item.ToLower()[0]))
                return String.Concat(item, "way");

            else
            {
                int count = 0;
                while (!IsVowel(item.ToLower()[count]))
                {
                    count++;
                }
                return item.Substring(count) + item.Substring(0, count) + "ay";
            }
        }

        public static bool IsVowel(char a)
        {
            switch (a)
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u': return true;
                default: return false;

            }
        }

        static void Main(string[] args)
        {
            string input;
            Console.Write("Enter a phrase in English: ");
            input = Console.ReadLine();

            string[] stringArray = input.Split(' ');

            for (int i=0; i < stringArray.Length; i++)
            {
                stringArray[i] = Translate(stringArray[i]);
            }

            foreach(string s in stringArray)
            {
                Console.Write(s + " ");
            }
            Console.WriteLine();
        }
    }
}
