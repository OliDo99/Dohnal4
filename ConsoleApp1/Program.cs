using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Clovek clovek = new Clovek(16, (float)183.5, "Janko");
            Ziak ziak = new Ziak(15, (float)170.5, "Janka", 6);

            Console.WriteLine("Vek cloveka je: " + clovek.getVek());
            Console.WriteLine("Vyska cloveka je: " + clovek.getVyska());
            Console.WriteLine("Meno cloveka je: " + clovek.getMeno());

            Console.WriteLine("Vek ziaka je: " + ziak.getVek());
            Console.WriteLine("Vyska ziaka je: " + ziak.getVyska());
            Console.WriteLine("Meno ziaka je: " + ziak.getMeno());
            Console.WriteLine("Trieda ziaka je: " + ziak.getTrieda());

            Console.ReadLine();

            /*
                1
                    Konštruktor nevracia hodnotu,
                    Slúži na inicializáciu objektu.
                    Konštruktor má rovnaký názov ako trieda, v ktorej sa nachádza.
                    Je volaný automaticky pri vytváraní inštancie triedy.
      
                2
                    Pri pretazeni metody mame napriklad dve metody napriklad s inym datovym typom (int-float) a program vyberie vhodnu
                    Pri predefinovani ju iba prepiseme
       
                3
                    Statická metóda nepotrebuje instanciu triedy na jej zavolanie
                    Nestaticka potrebuje instanciu
             */

        }
    }
}
