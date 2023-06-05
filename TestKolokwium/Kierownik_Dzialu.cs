using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestKolokwium
{
    public class Kierownik_Dzialu : Osoba
    {

        public int ocena_pracy_prac;

        public Kierownik_Dzialu(int ocena_pracy_prac, string name, string surname, int rok_rozp_prac, int sr_mes_wynag, double ocena_pracy_prze) : base(name, surname, rok_rozp_prac, sr_mes_wynag, ocena_pracy_prze)
        {
            this.ocena_pracy_prac = ocena_pracy_prac;
        }

        public string KierownikWiew()
        {
            return string.Format("Info: \n imie {0} \n nazwisko {2} \n rok_rozp_prac {1} \n sr_mes_wynag {3} \n ocena_praacy_prze {4} \n ocena_prac: {5}", name, surname, rok_rozp_prac, sr_mes_wynag, ocena_pracy_prze, ocena_pracy_prac);
        }
    }
}
