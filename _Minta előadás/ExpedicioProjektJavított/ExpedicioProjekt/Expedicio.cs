using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ExpedicioProjekt
{
    internal class Expedicio
    {
        private string fajl;
        private List<Uzenet> uzenetek = new List<Uzenet>();
        private List<string> megfejtettuzenetek = new List<string>();


        public Expedicio(string fajl)
        {
            this.fajl = fajl;

            Beolvas();
        }

        internal void Megfejt()
        {
            var napok =
                from uzenet in uzenetek
                group uzenet by uzenet.nap into groups
                orderby groups.Key
                select new { nap = groups.Key };

            foreach (var nap in napok)
            {
                var aznapiuzenetek = uzenetek.Where(a => a.nap == nap.nap).ToList();
                string megfejtettuzenet = "";
                string elsouzenet = aznapiuzenetek[0].uzenet;
                for (int i = 0; i < elsouzenet.Length; i++)
                {
                    char karakter = elsouzenet[i];
                    megfejtettuzenet += Megfejtes(karakter, aznapiuzenetek, i);
                }
                megfejtettuzenetek.Add($"{nap.nap}. {megfejtettuzenet}");
            }

            File.WriteAllLines("veetelMegfejtett.txt", megfejtettuzenetek);
        }

        private static string Megfejtes(char karakter, List<Uzenet> aznapiuzenetek, int i)
        {
            string vissza = "#";
            if (karakter != '#')
            {
                vissza = karakter.ToString();
            }
            else
            {
                for (int j = 1; j < aznapiuzenetek.Count; j++)
                {
                    if (aznapiuzenetek[j].uzenet[i] != '#')
                    {
                        vissza = aznapiuzenetek[j].uzenet[i].ToString();
                        break;
                    }
                }
            }
            return vissza;
        }

        private void Beolvas()
        {
            string[] sorok = File.ReadAllLines(fajl);
            int nap = 0;
            int amator = 0;

            for (int i = 0; i < sorok.Length; i++)
            {
                int mutato = i % 2;
                if (mutato == 0)
                {
                    string[] oszlopok = sorok[i].Split(' ');
                    nap = int.Parse(oszlopok[0]);
                    amator = int.Parse(oszlopok[1]);
                }
                else
                {
                    string uzenet = sorok[i];
                    uzenetek.Add(new Uzenet(nap, amator, uzenet));
                }
            }
        }

        internal void Statisztika()
        {
            List<string> fajlSorok = new List<string>();

            for (int i = 0; i < megfejtettuzenetek.Count; i++)
            {
                int nap = i + 1;
                int amatorokSzama = uzenetek.Count(u => u.nap == nap);
                int felnottFarkas = 0;
                int gyerekFarkas = 0;

                Match match = Regex.Match(megfejtettuzenetek[i], @"(\d+)/(\d+)");
                if (match.Success)
                {
                    string x = match.Value;
                    felnottFarkas = int.Parse(match.Groups[1].Value);
                    gyerekFarkas = int.Parse(match.Groups[2].Value);
                }

                string fF = felnottFarkas == 0 ? "-" : felnottFarkas.ToString();
                string gyF = gyerekFarkas == 0 ? "-" : gyerekFarkas.ToString();
                string sor = $"{nap};{amatorokSzama};{fF};{gyF}";
                fajlSorok.Add(sor);
            }
            File.WriteAllLines("napiStatisztika.txt", fajlSorok);
        }

        public void akármi()
        {
            throw new System.NotImplementedException();
        }
    }
}

