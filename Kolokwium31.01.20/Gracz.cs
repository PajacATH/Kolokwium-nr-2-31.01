using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Linq;

namespace Kolokwium31._01._20
{
    class Gracz
    {
        public int Punkty { get; set; }
        public int Zwyciestwa { get; set; }
        public DateTime OstatniaAktywnosc { get; set; }

        IEnumerable<int> koleckja = Enumerable.Range(1, 100);
        public void Utworz()
        {
            Console.WriteLine($"Punkty: {Punkty}, Zwycięstwa: {Zwyciestwa}");
            Console.WriteLine($"Ostatnia aktywność: {OstatniaAktywnosc.ToShortDateString()}");
        }
        static public void Wypisz()
        {
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine($"{i}. miejsce: ");
            }
        }

        public Gracz(int pkt, int win, DateTime aktywnosc)
        {
            Punkty = pkt;
            Zwyciestwa = win;
            OstatniaAktywnosc = aktywnosc;
        }
    }
}
