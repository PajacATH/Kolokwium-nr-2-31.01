using System;
using System.Collections.Generic;
using System.Text;

namespace Kolokwium31._01._20
{
    interface IPrzesylka
    {
        int Nadaj();
        void Przekaz(string tekst);
        void Info();
        void Odbierz(int x);

    }
}
