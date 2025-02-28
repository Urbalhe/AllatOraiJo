public class ViziAllatok : Allat

{

	public ViziAllatok(string nev, string szín, int eletkor) : base(nev, szín, eletkor) { }

	public override void Jellemzo()

	{

		Console.WriteLine($"Vízállat: {Nev}, Szín: {Szín}, Sebesség: {sebsseg} kmh.");

	}

}

public class SzarazfoldiHideg : Allat

{

	public SzarazfoldiHideg(string nev, string szín, int eletkor) : base(nev, szín, eletkor) { }

	public override void Jellemzo()

	{

		Console.WriteLine($"Szárazföldi hideg állat: {Nev}, Szín: {Szín}, Sebesség: {sebsseg} kmh.");

	}

}

public class SzarazFoldiMediterran : Allat

{

	public SzarazFoldiMediterran(string nev, string szín, int eletkor) : base(nev, szín, eletkor) { }

	public override void Jellemzo()

	{

		Console.WriteLine($"Szárazföldi mediterrán állat: {Nev}, Szín: {Szín}, Sebesség: {sebsseg} kmh.");

	}

}

public class SzarazfoldiMeleg : Allat

{

	public SzarazfoldiMeleg(string nev, string szín, int eletkor) : base(nev, szín, eletkor) { }

	public override void Jellemzo()

	{

		Console.WriteLine($"Meleg szárazföldi állat: {Nev}, Szín: {Szín}, Sebesség: {sebsseg} kmh.");

	}

}

public class SzarazfoldiTropus : Allat

{

	public SzarazfoldiTropus(string nev, string szín, int eletkor) : base(nev, szín, eletkor) { }

	public override void Jellemzo()

	{

		Console.WriteLine($"Trópusi szárazföldi állat: {Nev}, Szín: {Szín}, Sebesség: {sebsseg} kmh.");

	}

}
