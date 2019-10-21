using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AukcioProjekt
{
    // -- 1/B: Készíts egy osztályt Festmeny névvel, az alábbi UML diagram alapján.
    class Festmeny
    {
        private string cim;
        private string festo;
        private string stilus;
        private int licitekSzama = 0;
        private int legmagasabbLicit = 100;
        private DateTime legmagasabbLicitIdeje;
        private bool elkelt = false;
        public Festmeny(string cim, string festo, string stilus)
        {
            this.cim = cim;
            this.festo = festo;
            this.stilus = stilus;
        }
        public string getFesto()
        {
            return "semmi";
        }
        public string getStilus()
        {
            return "semmi";
        }
        public int getLicitekSzama()
        {
            return 0;
        }
        public int getLegmagasabbLicit()
        {
            return 0;
        }
        public bool Elkelt()
        {
            return false;
        }
        public Licit()
        {
            while (elkelt == false)
            {
                // -- 1/C.1: Ha a festmény már elkelt akkor írja ki hibaüzenetet a konzolra és ne történjen semmi.
                if (elkelt == true)
                {
                    Console.WriteLine("A festmény elkelt!");
                    break;
                }
                // -- 1/C.2: Ha még nem volt licit akkor a kezdeti licit értékével (100$) licitáljon, majd növelje a licitek ◦ számát eggyel, és állítsa be a legutolsó licit idejét az aktuális időpontra.
                if (licitekSzama == 0)
                {
                    legmagasabbLicit = 100;
                    licitekSzama++;
                    legmagasabbLicitIdeje = DateTime.UtcNow;
                }
                // -- 1/C.3: Ha már volt licit, akkor állítsa be a legmagasabb licitet 10%-al nagyobbra, növelje a licitek számát eggyel, majd állítsa be a legutolsó licit idejét az aktuális időpontra.
                else
                {
                    legmagasabbLicit = legmagasabbLicit + legmagasabbLicit / 10;
                    licitekSzama++;
                    legmagasabbLicitIdeje = DateTime.UtcNow;
                }
            }

            return;
        }
        public Licit(int mertek)
        {
            // -- 1/C.5: A Licit(merek:int) eljárás működése hasonló legyen csak 10% helyett a megadott %-kal növelje a licitet. A paraméter csak 10 és 100 közötti szám legyen. Hibás paraméter esetén, konzolra hibaüzenetet írjon ki, és ne történjen licit. Ha már volt licit, akkor a licit eljárás, ezt a metódust hívja meg 10%-os mértékkel.
            while (elkelt == false)
            {
                if (elkelt == true)
                {
                    Console.WriteLine("A festmény elkelt!");
                    break;
                }
                if (licitekSzama == 0)
                {
                    legmagasabbLicit = 100;
                    licitekSzama++;
                    legmagasabbLicitIdeje = DateTime.UtcNow;
                }
                else
                {
                    if (mertek >= 10 && mertek <= 100)
                    {
                        legmagasabbLicit = legmagasabbLicit + legmagasabbLicit / 100 * mertek;
                        licitekSzama++;
                        legmagasabbLicitIdeje = DateTime.UtcNow;
                    }
                    else
                    {
                        Console.WriteLine("Hibás adat, nem érvenyes licit");
                        break;
                    }
                }
            }
            return;
        }
        // -- 1/D: Bővítsd ki az osztályt egy Kiir() függvénnyel, ami visszaadja az adatokat az alábbi formában:  festo : cim (stilus)  elkelt / nem kelt el  legmagasabbLicit $ - legutolsoLicitIdeje (összesen: licitekSzama db).
        public Kiir()
        {
            Console.WriteLine($"{festo} : {cim} ({stilus})");
            Console.WriteLine($"{elkelt}");
            Console.WriteLine($"{legmagasabbLicit} $ - {legmagasabbLicitIdeje} (összesen: {licitekSzama} db)");
            return;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
