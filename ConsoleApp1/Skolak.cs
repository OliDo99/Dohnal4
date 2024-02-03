using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Skolak : Deti
    {
        private int rocnik;
        private string trieda;
        private float priemer;
        public Skolak() 
        { 
            this.rocnik = 0;
            this.trieda = "";
            this.priemer = 0;
        }
        public Skolak(int rocnik,string trieda,float priemer):
            base(vek, vaha, vyska, cena)
        {
            this.rocnik = rocnik;
            this.trieda = trieda;
            this.priemer = priemer;
        }

        public void SetRocnik(int rocnik)
        {
            this.rocnik = rocnik;
        }
        public void SetVaha(string trieda)
        {
            this.trieda = trieda;
        }
        public void SetPriemer(int priemer)
        {
            this.priemer = priemer;
        }

        public int GetRocnik() { return this.rocnik; }
        public string GetTrieda() { return this.trieda; }
        public float GetPriemer() { return this.priemer; }
    }
}
