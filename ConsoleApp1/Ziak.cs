using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Ziak : Clovek
    {
        int trieda;
        public Ziak(int vek,float vyska,string meno, int trieda):base (vek,vyska,meno)
        {
            if (trieda >= 1)
            {
                this.trieda = trieda;
            }
            else { this.trieda = 0; }
        }
        public int getTrieda() { return this.trieda; }
        public void setTrieda(int trieda)
        {
            if (trieda >= 0) { this.trieda = trieda; } else { this.trieda = 0; }
        }
        new void setMeno(string prezyvka)
        {
            this.meno = prezyvka;
        }
    }
}
