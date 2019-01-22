using System;

namespace TicketCost_class_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! \nI will be your ticket price calculator today.");
            Ticket lippu = new Ticket();
            lippu.QsAndAs();
            lippu.CalculatePrice();
        }
    }

}