using System;

namespace Firma_Class_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Company yritys = new Company ("Future parrots", "Paradise avenue", "050123123", 500, 300);
            yritys.WinLossCounter();
        }
    }
}
