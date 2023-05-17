using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace КпияпСус
{
    internal class Лаб6
    {
        public static void Prog()
        {
            string str1 = "Таким образом консультация";
            String str2 = new('!', 10);
            char[] char1 = "Таким образом консультация".ToArray();
            string str3 = new(char1);
            string str4 = new(char1, 8, 9);
            Console.WriteLine(str1);
            Console.WriteLine(str2);
            Console.WriteLine(str3);
            Console.WriteLine(str4);
            Console.WriteLine(str1.StartsWith("обр"));
            Console.WriteLine(str2.StartsWith("обр"));
            Console.WriteLine(str3.StartsWith("обр"));
            Console.WriteLine(str4.StartsWith("обр"));
            StringBuilder strb = new("Таким образом консультация");
            Console.WriteLine(strb.Replace('а', 'о'));
        }
    }
}
