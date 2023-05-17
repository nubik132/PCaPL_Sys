using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace КпияпСус
{
    class Лаб5
    {
       public void bebra()
        {
            Console.WriteLine("{0}\n{1}\n{2}\n{3}\n{4}\n{5}\n",
                c(a, b),
                c(a, b, a),
                c(a, b, a, b, a),
                c(a, b, ref a),
                c(a, a, a, a, a, a, a),
                c((a, b)));
        }
        string a = "shaka";
        string b = "laka";
        string c(string a, string b) { return a + b; }
        string c(string a, string b, string c) { return a + b + c; }
        string c(string a, string b, string c, string chik, string d = "") { return a + b + c + d+chik; }
        string c(string a, string b, ref string c) { return a + b + c; }
        string c(params string[] a)
        {
            string kiki = "";
            for (int i = 0; i < a.Length; i++)
            {
                kiki += a[i];
            }
            return kiki;
        }
        string c((string, string)a) { return a.Item1 + a.Item2; }
    }
}
