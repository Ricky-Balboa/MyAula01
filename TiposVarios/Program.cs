﻿using System;

namespace TiposVarios
{
    class Program
    {


        static void Main(string[] args)
        {
            int x = 3;
            int y = 7;
            int a = 10;
            int b = 23;
            int c = 29;
            char d = '\u00B3';
            char e = '\u00C2';
            char f = '\u00D4';
            double g = 3.14;
            double h = 17.412;
            double i = 12.123;
            bool j = true;
            bool k = false;
            string l = "isto é uma string";
            string m = "Um tab\t e um omega \u03A9";
            string n = @"isto é uma string Verbatim (Literal)";
            string o = @"Um tab\t e um omega \u03A9 em verbatim ";
            string p = "x = ";
            string q = "y = ";
            string r = $"{x} mais {y}, é igual a {x+y}";



            Console.WriteLine("3 Inteiros");
            Console.WriteLine("");
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine("");
            Console.WriteLine("3 Caracteres");
            Console.WriteLine("");
            Console.WriteLine(d);
            Console.WriteLine(e);
            Console.WriteLine(f);
            Console.WriteLine("");
            Console.WriteLine("3 Reais");
            Console.WriteLine("");
            Console.WriteLine(g);
            Console.WriteLine(h);
            Console.WriteLine(i);
            Console.WriteLine("");
            Console.WriteLine("2 Booleanos");
            Console.WriteLine("");
            Console.WriteLine(j);
            Console.WriteLine(k);
            Console.WriteLine("");
            Console.WriteLine(l);
            Console.WriteLine("");
            Console.WriteLine(m);
            Console.WriteLine("");
            Console.WriteLine(n);
            Console.WriteLine("");
            Console.WriteLine(o);
            Console.WriteLine("");
            Console.WriteLine(p + x);
            Console.WriteLine("");
            Console.WriteLine(q + y);
            Console.WriteLine("");
            Console.WriteLine(r);
            Console.WriteLine("Carrega enter para fechar");

            Console.ReadKey();

        }
    }
}
