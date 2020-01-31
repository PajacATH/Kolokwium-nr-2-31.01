using System;
using System.Collections.Generic;
using System.Text;

namespace Kolokwium31._01._20
{
    class List : IPrzesylka
    {

        public string Tresc { get; set; }
        public string Lokalizacja { get; set; }
        public void Info()
        {
           
        }

        public int Nadaj()
        {
            int id = 12314;
            Console.WriteLine($"Ustawić {Lokalizacja} na BAZA");
            return id;
        }

        public void Odbierz(int x)
        {
            Console.WriteLine("KOMUNIKAT");
        }

        public void Przekaz(string tekst)
        {

            Lokalizacja += tekst;
        }

        public List(string tresc, string location)
        {
            Tresc = tresc;
            Lokalizacja = location;
        }
    }
}
