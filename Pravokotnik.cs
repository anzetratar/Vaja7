using System;

public class Pravokotnik
{
	private double a;
	private double b;

    public Pravokotnik()
	{
		a = 1;
		b = 1;
    }

	public Pravokotnik(double a, double b)
	{
        this.a = a;
        this.b = b;
    }

	public void Nastavi()
	{
		double str_a, str_b;

        Console.WriteLine("Vnesi dolzino stranice a: ");
        str_a = double.Parse(Console.ReadLine());

        Console.WriteLine("Vnesi dolzino stranice b: ");
        str_b = double.Parse(Console.ReadLine());

        a = str_a;
        b = str_b;
    }

    public double Ploscina()
    {
        return a * b;
    }

    public double Obseg()
    {
        return 2*a + 2*b;
    }
}
