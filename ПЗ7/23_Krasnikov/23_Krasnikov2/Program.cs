using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace compare
{
    class Program
    {
        static void Main(string[] args)
        {
            FindInString();
            DeleteString();
            ReplaceString();
            UpperString();
        }
        static void FindInString()
        {
            string s1 = "Я скоро поеду на научную конференцию в Курск";

            string subString = "Курск";
            int indexOfSubstring = s1.IndexOf(subString);
            Console.WriteLine("Индекс подстроки в строке {0} - {1}", subString, indexOfSubstring);
        }

        static void DeleteString()
        {
            string s1 = "Я скоро поеду на научную конференцию в Курск";
            int ind = s1.Length - 8;
            s1 = s1.Remove(ind);
            Console.WriteLine(s1);
        }
        static void ReplaceString()
        {
            string s1 = "Я скоро поеду на научную конференцию в Курск";
            s1 = s1.Replace("научную конференцию", "соревнование");
            Console.WriteLine(s1);
        }
        static void UpperString()
        {
            string s1 = "Я скоро поеду на научную конференцию в Курск";
            Console.WriteLine(s1.ToUpper());
        }
    }
}