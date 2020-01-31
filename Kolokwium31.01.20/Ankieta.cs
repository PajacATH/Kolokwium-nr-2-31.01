using System;
using System.Collections.Generic;
using System.Text;

namespace Kolokwium31._01._20
{
    class Ankieta
    {
        public int A { get; set; }
        public int B { get; set; }
        public int C { get; set; }
        public int D { get; set; }
        public int Suma { get; set; }

        public Ankieta(int a, int b, int c, int d)
        {
            A = a;
            B = b;
            C = c;
            D = d;
            Suma = a + b + c + d;
        }

        public void Deconstruct(out int a, out int b, out int c, out int d, out int suma)
        {
            a = A;
            b = B;
            c = C;
            d = D;
            suma = Suma;
            //Console.WriteLine($"A: {a}");
            //Console.WriteLine($"B: {b}");
            //Console.WriteLine($"C: {c}");
            //Console.WriteLine($"D: {d}");
            //Console.WriteLine($"Suma: {suma}");
        }

        public void Deconstruct(out int a, out int b, out int c, out int d)
        {
            
            a = A;
            b = B;
            c = C;
            d = D;
            double suma = a + b + c + d;

            Console.WriteLine($"A: {Math.Round((a / suma)*100,2)}%");
            Console.WriteLine($"B: {Math.Round((b / suma) * 100, 2)}%");
            Console.WriteLine($"C: {Math.Round((c / suma) * 100, 2)}%");
            Console.WriteLine($"D: {Math.Round((d / suma) * 100, 2)}%");
        }
    }
}
