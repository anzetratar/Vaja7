using System;

public class Krog
{
    public Krog()
    {
        private int r;
        r = 1;
	}

    public Krog(int a)
    {
        r = a;
    }
    public void nastavir()
    {
     Console.Write("Vnesi polmer kroga: ");
     Krog.r = int.Parse(Console.ReadLine());
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