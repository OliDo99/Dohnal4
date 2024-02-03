using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Clovek
    {
        protected int vek;
        protected float vyska;
        protected string meno;
        public Clovek()
        {
            this.vek = 0;
            this.vyska = 0;
            this.meno = "";
        }
        public Clovek(int vek,float vyska, string meno)
        {
            if (vek >= 0) { this.vek = vek; } else { this.vek = 0; }
            if (vyska >= 0) { this.vyska = vyska; } else { this.vyska = 0; }
            this.meno = meno;
        }
        public int getVek() { return this.vek; }
        public float getVyska() { return this.vyska; }
        public string getMeno() { return this.meno; }

        public void setVek(int vek)
        {
            if(vek >= 0) { this.vek = vek; } else { this.vek = 0; }
        }
        public void setVyska(float vyska)
        {
            if (vek >= 0) { this.vyska = vyska; } else { this.vyska = 0; }
        }
        public void setMeno(string meno)
        {
            this.meno = meno; 
        }
    }
}
