using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankiSzolgaltatasok
{
	public class HitelSzamla : Szamla
	{
		private int hitelKeret;

		public HitelSzamla(Tulajdonos tulajdonos, int hitelKeret) : base(tulajdonos)
		{
			this.hitelKeret = hitelKeret;
		}
		public override bool Kivesz(int osszeg)
		{
				return this.hitelKeret >= osszeg;
		}

		public int HitelKeret { get => hitelKeret; }
	}
}
