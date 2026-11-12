using System;

namespace ConsoleApp1
{
    public class Krog
    {
        private int r;

        public Krog()
        {
            r = 1;
        }

        public Krog(int a)
        {
            r = a;
        }

        public void nastavir()
        {
            Console.Write("Vnesi polmer kroga: ");
            r = int.Parse(Console.ReadLine());
        }

        public void ploscina()
        {
            double ploscina = Math.PI * r * r;
            Console.WriteLine("Ploščina kroga je: " + ploscina);
        }

        public void obseg()
        {
            double obseg = 2 * Math.PI * r;
            Console.WriteLine("Obseg kroga je: " + obseg);
        }
    }
}