using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2018_11_16_Adatszerkezetek_Binaris_fa
{
    class Program
    {
        class Szemelyi_Adatok
        {
            public Szemelyi_Adatok(string teljes_nev, DateTime szuldatum)
            {
                Teljes_nev = teljes_nev;
                Szuldatum = szuldatum;
            }

            public string Teljes_nev { get; private set; }
            public DateTime Szuldatum { get; private set; }
        }
        static void Main(string[] args)
        {
            // https://github.com/bartab9610/2018_11_16_Adatszerkezet_Binaris_fa.git
            ISet<string> halmaz = new SortedSet<string>();

            halmaz.Add("Elem_6");
            halmaz.Add("Elem_153");
            halmaz.Add("Elem_24");
            halmaz.Add("Elem_4");
            halmaz.Add("Elem_5");
            halmaz.Add("Elem_3");
            halmaz.Add("Elem_6");
            foreach (var elem in halmaz)
            {
                Console.Write(elem + ", ");
            }
            Console.WriteLine();
            Console.WriteLine(halmaz.Contains("Elem_24"));
            Console.WriteLine(halmaz.Contains("Elem_9"));
            Console.WriteLine();

            IDictionary<string, double> dict = new SortedDictionary<string, double>();
            dict.Add("User1", 178.5);
            dict.Add("Kovacs_bela", 178.5);
            dict.Add("Kovacs_bela2", 178.5);
            foreach (var elem in dict)
            {
                Console.WriteLine("{0} magassag {1}",elem.Key,elem.Value);
            }
            double magassag = dict["Kovacs_bela"];
            Console.WriteLine(magassag);
            Console.WriteLine();

            IDictionary<string, Szemelyi_Adatok> dict2 = new SortedDictionary<string, Szemelyi_Adatok>();
            dict2.Add("Kovacs_bela", new Szemelyi_Adatok("Kovacs Bela", new DateTime(1996, 1, 1)));
            string username = "Kovacs_bela";
            if (dict2.ContainsKey(username))
            {
                Szemelyi_Adatok adatok = dict2[username];
                Console.WriteLine(adatok.Teljes_nev);
            }
            Console.ReadKey();
        }
    }
}