using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Deti
    {
        protected int vek, vaha;
        protected float vyska, cena;


        public Deti() 
        {
            this.vek = 0;
            this.vaha = 0;
            this.vyska = 0;
            this.cena = 0;
        }
        public Deti(int vek,int vaha, float vyska, float cena)
        {
            this.vek = vek;
            this.vaha = vaha;
            this.vyska = vyska;
            this.cena = cena;
        }


        public void SetVek(int vek)
        {
            this.vek = vek;
        }
        public void SetVaha(int vaha)
        {
            this.vaha = vaha;
        }
        public void SetVyska(int vyska)
        {
            this.vyska = vyska;
        }
        public void SetCena(int cena)
        {
            this.cena = cena;
        }


        public int GetVek() { return this.vek; }
        public int GetVaha() { return this.vaha; }
        public float GetVyska() { return this.vyska; }
        public float GetCena() { return this.cena; }


    }
}
