namespace AllatOraiJo
{
	internal class Program
	{
		static void Main(string[] args)
		{


			List<Allat> allatLista = new List<Allat>
	{
				new ViziAllatok(40, 75, 5, "Morzsi")
		//new ViziAllatok("Cápa", "kék", 10),
		//new SzarazfoldiHideg("Medve", "fehér", 28),
		//new SzarazfoldiHideg("Medve Fehér", "fehér", 23),
		//new SzarazFoldiMediterran("Kecske", "sárga", 2),
		//new MelegSzarazfoldi("Kobra", "zöld", 3),
		//new TropusiSzarazfold("Papagáj", "piros", 20),
		//new TropusiSzarazfold("Gepard", "glamur", 31),


	};

			foreach (var allat in allatLista)
			{
				allat.Jellemzo();
			}





		}
	}
}
