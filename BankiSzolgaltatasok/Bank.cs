using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankiSzolgaltatasok
{
    internal class Bank
    {
        private List<Szamla> list;

        public Bank()
        {
            this.list = new List<Szamla>();
        }
        public Szamla SzamlaNyitas(Tulajdonos tulajdonos, int hitelkeret)
        {
            if (hitelkeret==0)
            {
                MegtakaritasiSzamla megtakaritasiszamla = new MegtakaritasiSzamla(tulajdonos);
                list.Add(megtakaritasiszamla);
                return megtakaritasiszamla;
            }
            else if (hitelkeret>0)
            {
                HitelSzamla hitelszamla = new HitelSzamla(tulajdonos, hitelkeret);
                list.Add(hitelszamla);
                return hitelszamla;
            }
            else
            {
                throw new ArgumentException("A hitelkeret negatív", nameof(hitelkeret));
            }
        }
        public double GetOsszEgyenleg(Tulajdonos tulajdonos)
        {
            double ossz = 0;
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Tulajdonos==tulajdonos)
                {
                    ossz = ossz + list[i].aktualisEgyenlegx;
                }
            }
            return ossz;
        }
        public Szamla GetLegnagyobbEgyenleguSzamla(Tulajdonos tulajdonos)
        {
            double max = double.MinValue;
            Szamla szamlaszam = this.list[0];
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Tulajdonos == tulajdonos)
                {
                    if (list[i].aktualisEgyenlegx>max)
                    {
                        max = list[i].aktualisEgyenlegx;
                        szamlaszam = list[i];
                    }
                }
            }
            return szamlaszam;
        }
        public double OsszHitelkeret
        {
            get
            {
                double ossz = 0;
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i].GetType() == typeof(HitelSzamla))
                    {
                        HitelSzamla szamla = (HitelSzamla)list[i];
                        ossz += szamla.hitelKeretx;
                    }
                }
                return ossz;
            }
        }
    }
}
