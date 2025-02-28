using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllatOraiJo
{
	internal class SzarazfoldiHideg
	{
		int sebesseg;
		int suly;
		int kor;
		string nev;
		string elohely;

		public SzarazfoldiHideg(int sebesseg, int suly, int kor, string nev)
		{
			this.sebesseg = sebesseg;
			this.suly = suly;
			this.kor = kor;
			this.nev = nev;
			this.elohely = "SZárazföldi hideg éghajlat.";
		}

		public int Sebesseg { get => sebesseg; set => sebesseg = value; }
		public int Suly { get => suly; set => suly = value; }
		public int Kor { get => kor; set => kor = value; }
		public string Nev { get => nev; set => nev = value; }
		public string Elohely { get => elohely; set => elohely = value; }

		public override string? ToString()
		{
			return $"Név: {nev}, Kor: {kor}, Súly: {suly}, Sebesség: {sebesseg}";
		}
	}

	
}
