namespace BankiSzolgaltatasok
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //Tesztelések (törölje kérem a "/*"-eket!!) <--------------------------------------------------------------------------------------------------------------





            /*
            Tulajdonos t1 = new Tulajdonos("Fütty Imre");
            Tulajdonos t2 = new Tulajdonos("Pofá Zoltán");
            Bank bank = new Bank();

            try
            {
                bank.SzamlaNyitas(t1, -1);
            }
            catch (ArgumentException exception)
            {
                Console.WriteLine(exception.Message); //A hitelkeret negatív lesz a -1 miatt
            }

            Szamla szamla1 = bank.SzamlaNyitas(t1, 0);
            szamla1.Befizet(100);

            Szamla szamla2 = bank.SzamlaNyitas(t2, 100);
            szamla2.Befizet(10);
            szamla2.Befizet(20);


            Kartya kartya1 = szamla1.UjKartya("4375 5210 9432 5671");
            Kartya kartya2 = szamla2.UjKartya("5467 2134 5766 9674");

            Console.WriteLine("Vásárlás-----");
            Console.WriteLine($"Egyenleg: {szamla1.aktualisEgyenlegx} ft");
            if (kartya1.Vasarlas(50)) //<-- tetszőleges összeg
            {
                Console.WriteLine("Siker!");
                Console.WriteLine($"Egyenleg: {szamla1.aktualisEgyenlegx} ft\n");
            }
            else
            {
                Console.WriteLine("Sikertelen!\n");
            }

            Console.WriteLine("Kamatjóváírás-----");
            MegtakaritasiSzamla mszamla = (MegtakaritasiSzamla)szamla1;
            Console.WriteLine($"Egyenleg: {mszamla.aktualisEgyenlegx} Ft");
            mszamla.KamatJovairas();
            Console.WriteLine($"Egyenleg: {mszamla.aktualisEgyenlegx} Ft\n");

            Console.WriteLine("Pénzkivétel-----");
            Console.WriteLine($"Egyenleg: {szamla1.aktualisEgyenlegx} Ft");
            if (szamla1.Kivesz(1)) //<-- tetszőleges összeg
            {
                Console.WriteLine("Sikeres pénzkivétel!");
                Console.WriteLine($"Egyenleg: {szamla1.aktualisEgyenlegx} Ft\n");
            }
            else
            {
                Console.WriteLine("Sikertelen pénzkivétel!\n");
            }

            Console.WriteLine("Pénzkivétel megtakarítási számláról-----");
            Console.WriteLine($"Egyenleg: {szamla1.aktualisEgyenlegx} Ft");
            if (szamla1.Kivesz(10))
            {
                Console.WriteLine("Sikeres pénzkivétel!");
                Console.WriteLine($"Egyenleg: {szamla1.aktualisEgyenlegx} Ft\n");
            }
            else
            {
                Console.WriteLine("Sikertelen pénzkivétel!\n");
            }

            
            Console.WriteLine($"Összhitelkeret: {bank.OsszHitelkeret} Ft\n");
            
            Console.WriteLine($"{t1.Nev} összegyenlege: {bank.GetOsszEgyenleg(t1)} Ft\n");

            Console.WriteLine($"{t1.Nev} legnagyobb egyenlege: {bank.GetLegnagyobbEgyenleguSzamla(t1).aktualisEgyenlegx} Ft\n");
            */
        }
    }
}