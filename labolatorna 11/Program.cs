using System;
using System.Diagnostics;
using System.Net.Mail;
using labolatorna_11.Artisans;

namespace labolatorna_11
{
    class Program
    {
        static void Main(string[] args)
        {
            var clockInTown = Clock.GetInstance();

            clockInTown.Attach(new Baker());
            clockInTown.Attach(new Shoemaker());
            clockInTown.Attach(new Barkeeper());

            while (clockInTown.UpdateTime() != 0) { Console.WriteLine();}

            Console.WriteLine("press any key to end!");
            Console.ReadKey();
        }
    }
}
