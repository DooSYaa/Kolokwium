using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestKolokwium
{
    public class Osoba
    {
        public string name;
        public string surname;
        public int rok_rozp_prac;
        public int sr_mes_wynag;
        public double ocena_pracy_prze;

        public Osoba(string name, string surname, int rok_rozp_prac, int sr_mes_wynag, double ocena_pracy_prze) 
        {

            this.name = name;
            this.surname = surname; 
            this.rok_rozp_prac = rok_rozp_prac;
            this.sr_mes_wynag = sr_mes_wynag;
            this.ocena_pracy_prze = ocena_pracy_prze;

        }

      
    }
}
