using System;
using System.Security.Authentication.ExtendedProtection;

namespace C_2_ukol3_Seznamy_slovniky_a_datum_a_cas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Vypiš aktuální datum a čas, nemusíš řešit, v kterém je to časovém pásmu.
            DateTime datumACas = DateTime.Now;
            Console.WriteLine($"Aktuální datum a čas je: {datumACas}");

            // 2. Vytvoř proměnnou typu DateTime a ulož do ní svoje datum narození. Potom vypiš, kolik dnů od té doby uteklo.
            DateTime mojeDatumNarozeni = new DateTime(1995, 10, 5);
            TimeSpan casOdNarozeni = datumACas - mojeDatumNarozeni;
            int pocetDnuOdNarozeni = casOdNarozeni.Days;
            Console.WriteLine($"Počet dnů od mého narození je: {pocetDnuOdNarozeni}");


            // 3. Vytvoř list stringů a vlož do něj 5 různých hodnot.
            List<string> stringy = new List<string>();
            stringy.Add("prase");
            stringy.Add("slepice");
            stringy.Add("pes");
            stringy.Add("koza");
            stringy.Add("osel");

            Console.Write("Obsah listu: ");
            foreach (string str in stringy) 
            {
                Console.Write(str + " ");
            }
            Console.WriteLine();

            // 4. Smaž z tohoto listu libovolnou hodnotu.
            stringy.Remove("koza");
            Console.Write("Obsah listu po odebrání kozy: ");
            foreach (string str in stringy)
            {
                Console.Write(str + " ");
            }
            Console.WriteLine();

            // 5. Zjisti, jestli tento list obsahuje nějakou hodnotu pomocí list metody Contains
            Console.WriteLine("Je v listu pes: " + stringy.Contains("pes"));
            Console.WriteLine("Je v listu lev: " + stringy.Contains("lev"));
            Console.WriteLine("Je v listu koza: " + stringy.Contains("koza"));

            // 6. Vypiš do konzole, kolik je v tom listu prvků a připoj k tomu všechny ty hodnoty (např: "2: modra, zelena").
            int pocetStringu = stringy.Count;
            Console.Write($"List obsahuje {pocetStringu} prvky: ");
            for (int i = 0; i < (pocetStringu - 1); i++)
            {
                Console.Write($"{stringy[i]}, ");
            }
            Console.WriteLine(stringy[pocetStringu - 1]);

            // 7. Vytvoř slovník, kde klíčem bude položka nákupu (string) a hodnotou cena té položky, a vlož nějaké hodnoty (např: <"chleba", 20>).
            Dictionary<string, int> nakup = new Dictionary<string,int>();
            nakup.Add("chleba", 55);
            nakup.Add("sýr", 34);
            nakup.Add("rajče", 8);
            nakup.Add("čokoláda", 44);

            // 8. Zjisti, jestli slovník obsahuje nějakou konkrétní potravinu a pokud ano, vypiš její cenu, pokud ne, vypiš, že není.
            string hledanaPolozka = "chleba";
            if (nakup.ContainsKey(hledanaPolozka))
            {
                Console.WriteLine($"Cena položky {hledanaPolozka} je {nakup[hledanaPolozka]} Kč.");
            }
            else
            {
                Console.WriteLine("Tato položka v seznamu není.");
            }

            // 9. Řekněme, že už jsi do slovníku přidala např. chleba a zjistila, že máš v nákupní tašce ještě jeden -> uprav hodnotu k tomu klíči tak, aby obsahovala hromadnou cenu za všechny stejné položky.
            string pridanaPolozka = "chleba";
            int cenaPridanePolozky = 24;
            if (nakup.ContainsKey(pridanaPolozka))
            {
                nakup[pridanaPolozka] = nakup[pridanaPolozka] + cenaPridanePolozky;
            }
            else
            {
                nakup.Add(pridanaPolozka, cenaPridanePolozky);
            }


            Console.WriteLine("Cena položky chleba po přidání druhého: " + nakup[pridanaPolozka]);

        }
    }
}
