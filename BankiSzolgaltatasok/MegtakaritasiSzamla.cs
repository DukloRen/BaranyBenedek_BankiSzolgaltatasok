using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankiSzolgaltatasok
{
	public class MegtakaritasiSzamla : Szamla
	{
		public static double alapKamat = 1.1;
		private double kamat;

		public MegtakaritasiSzamla(Tulajdonos tulajdonos) : base(tulajdonos)
		{
			this.kamat = alapKamat;
		}

		public double Kamat { get => kamat; set => kamat = value; }
		public void KamatJovairas()
		{
			aktualisEgyenleg
		}
		public bool Kivesz(int osszeg)
		{
			if (osszeg >= 0)
			{
				return true;
			}
			else{
				return false; 
			}	
		}
	}
}
