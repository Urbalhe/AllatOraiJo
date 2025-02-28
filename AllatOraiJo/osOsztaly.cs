using System;
using System.Collections.Generic;

public class Allat
{
	public string Nev { get; set; }
	public string Szín { get; set; }
	public int sebsseg { get; set; }

	public Allat(string nev, string szín, int kor)
	{
		int sebesseg;
		int suly;
		int kor;
		string nev;
		string elohely;
	}

	public virtual void Jellemzo()
	{
		Console.WriteLine($"Állat neve: {Nev}, Szín: {Szín}, Életkor: {sebsseg} év.");
	}
}
