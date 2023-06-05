using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestKolokwium
{
    public class Pracownik_Dzialu : Osoba
    {
        public double proc_zad;
        public int year = DateTime.Now.Year;
        public double Baz_prem;
        

        public Pracownik_Dzialu(double proc_zad, string name, string surname, int rok_rozp_prac, int sr_mes_wynag, double ocena_pracy_prze) : base(name, surname, rok_rozp_prac, sr_mes_wynag, ocena_pracy_prze)
        {
            this.proc_zad = proc_zad;
        }


        public void Staz_Pracy()
        {
            if ((year - this.rok_rozp_prac) >= 5 && (year - this.rok_rozp_prac) < 10)
            {
                this.Baz_prem = (this.sr_mes_wynag * 50) / 100;
            }

            else if ((year - this.rok_rozp_prac) >= 10 && (year - this.rok_rozp_prac) < 15)
            {
                this.Baz_prem = (this.sr_mes_wynag * 75) / 100;
            }

            else if ((year - this.rok_rozp_prac) >= 15 && (year - this.rok_rozp_prac) < 20)
            {
                this.Baz_prem = this.sr_mes_wynag * 2;
            }

            else if ((year - this.rok_rozp_prac) >= 20)
            {
                this.Baz_prem = (this.sr_mes_wynag * 150) / 100;
            }
            
        }

        public double Ocena()
        {
            Staz_Pracy();
            if ((this.ocena_pracy_prze >= 1) && (this.ocena_pracy_prze < 2))
            {
                this.Baz_prem = (this.sr_mes_wynag / 100) / 100;
            }

            else if ((this.ocena_pracy_prze >= 2) && (this.ocena_pracy_prze < 3))
            {
                this.Baz_prem = this.Baz_prem;
            }

            else if ((this.ocena_pracy_prze >= 3) && (this.ocena_pracy_prze < 4))
            {
                this.Baz_prem = (this.sr_mes_wynag * 50) / 100;
            }

            else if (this.ocena_pracy_prze >= 4)
            {
                this.Baz_prem = this.sr_mes_wynag * 2;
            }
            return Convert.ToInt32(Baz_prem);
        }



            public string DaneWiew()
        {
            return string.Format("Info: \n imie {0} \n nazwisko {2} \n rok_rozp_prac {1} \n sr_mes_wynag {3} \n ocena_praacy_prze {4} \n procent: {5} \n Baz_Prem: {6}" + Ocena(), name, surname, rok_rozp_prac, sr_mes_wynag, ocena_pracy_prze, proc_zad, Baz_prem);
        }
    }
}
