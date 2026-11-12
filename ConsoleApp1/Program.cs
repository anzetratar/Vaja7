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
            Krog krog1 = new Krog(5);
            Krog krog2 = new Krog(6);
            krog1.ploscina();
            krog2.ploscina();
        }
            
    }
}
