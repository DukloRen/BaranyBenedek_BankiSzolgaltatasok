using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankiSzolgaltatasok
{
	public abstract class Szamla : BankiSzolgaltatas
	{
		protected int aktualisEgyenleg;
		public int aktualisEgyenlegx { get => aktualisEgyenleg; }

		public Szamla(Tulajdonos tulajdonos) : base (tulajdonos)
		{

		}
		public void Befizet(int osszeg)
		{
			this.aktualisEgyenleg += osszeg;
		}
		public abstract bool Kivesz(int osszeg);
		public Kartya UjKartya(string kartyaszam)
		{
			return new Kartya(this.Tulajdonos, this, kartyaszam);
		}
	}
}
