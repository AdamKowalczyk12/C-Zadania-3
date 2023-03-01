using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Towar
    {
        public string Symbol { get; set; }
        public string Nazwa { get; set; }
        public double Cena { get; set; }

        public Towar(string symbol, string nazwa, double cena)
        {
            Symbol = symbol;
            Nazwa = nazwa;
            Cena = cena;
        }
    }
}
