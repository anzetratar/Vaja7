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
    private void nastavir()
    {
     Console.Write("Vnesi polmer kroga: ");
     Krog.r = int.Parse(Console.ReadLine());
}   
}
