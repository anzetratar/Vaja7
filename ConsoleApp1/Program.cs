using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pravokotnik p = new Pravokotnik(3, 3);
            Pravokotnik p1 = new Pravokotnik(6, 4);

            p.Ploscina();
            p1.Ploscina();
        }
    }
}
