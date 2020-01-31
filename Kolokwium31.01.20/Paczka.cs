using System;
using System.Collections.Generic;
using System.Text;

namespace Kolokwium31._01._20
{
    class Paczka : IPrzesylka
    {
        public int Waga { get; set; }
        public string Lokalizacja { get; set; }
        public void Info()
        {
            Console.WriteLine($"Typ: Paczka \nWaga: {Waga} \nLokalizacja: {Lokalizacja}");
        }

        public int Nadaj()
        {
            int id = 12314;
            Console.WriteLine($"Ustawić {Lokalizacja} na BAZA" );
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

        public Paczka(int waga, string location)
        {
            Waga = waga;
            Lokalizacja = location;
        }
    }
}
