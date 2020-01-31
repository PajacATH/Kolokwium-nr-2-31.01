using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Linq;
using System.IO;

namespace Kolokwium31._01._20
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 1D
            var kolekcja = new List<Gracz>();
            var data = new DateTime(2020, 1, 30, 15, 30, 2);
            kolekcja.ForEach(x => 
            {
                int i = 1;
                x = new Gracz((22+(i*2)), (5+i), data);
                i++;
            }) ;
            Console.WriteLine("Ranking zwycięstw!");
            foreach (var x in kolekcja)
            {
                int i = 1;
                Console.WriteLine($"{i}. miejsce: {x.Zwyciestwa}");
                i++;
            }

            Console.WriteLine("Ranking punktów");
            foreach (var x in kolekcja)
            {
                int i = 1;
                Console.WriteLine($"{i}. miejsce: {x.Punkty}");
                i++;
            }

            foreach (var x in kolekcja)
            {
                int i = 1;
                if (x.OstatniaAktywnosc <= DateTime.Now)
                {
                    Console.WriteLine($"Miejsce {i}. KDA: {x.Punkty / x.Zwyciestwa}");
                    i++;
                }
            }

            var data1 = new DateTime(2020, 1, 30, 15, 30, 2);
            var gracz1 = new Gracz(27, 4, data1);
            

            var data2 = new DateTime(2020, 1, 27, 13, 30, 2);
            var gracz2 = new Gracz(12, 1, data2);

            var data3 = new DateTime(2020, 1, 17, 23, 30, 2);
            var gracz3 = new Gracz(34, 3, data3);

            var data4 = new DateTime(2020, 1, 24, 18, 50, 2);
            var gracz4 = new Gracz(53, 7, data4);

            var punkty = kolekcja.OrderByDescending(x => x.Punkty);
            var wins = kolekcja.OrderByDescending(x => x.Zwyciestwa);
            
            Console.WriteLine("Ranking punktów!");
            //punkty.ForEach(x =>
            //{
            //    int i = 1;
            //    Console.WriteLine($"{i}. miejsce: {x}");
            //    i++;
            //});

            #endregion

            #region 2D

            var paczuszka = new Paczka(12, "New Zeland");
            var listyDoM = new List("Tekst listu nie zawsze musi być sensowny", "Kędzierzyn-Koźle");

            #endregion

            #region 3D
            /*
            var glosowanie = new Ankieta(12,34,2,22);
            
            var (a, b, c, d, suma) = glosowanie;

            var (aa, bb, cc, dd) = glosowanie;

            */
            #endregion

            #region 4D



            #endregion

            #region 5D

            var sr = new StreamReader("tekst.txt");
            string kopia = sr.ReadToEnd();

            StreamWriter plik = File.CreateText("kopia.txt");
            plik.WriteLine(kopia);

            #endregion
        }
    }
}
