using HerancaMultipla.Devices;
using System;

namespace HerancaMultipla
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Printer p = new Printer() { SerialNumber = 1000 };
            p.ProcessDoc("My letter");
            p.Print("My letter");

            Scanner s = new Scanner() { SerialNumber = 2003 };
            s.ProcessDoc("My Email");
            Console.WriteLine(s.Scan());

            ComboDevice c = new ComboDevice() { SerialNumber = 3921};
            c.ProcessDoc("My dissertation");
            c.Print("My dissetation");
            Console.WriteLine(c.Scan());
        }
    }
}
