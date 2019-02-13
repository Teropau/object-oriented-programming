using System;

namespace Kirja_Ja_Kirjailija_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Kirja ja kirjailija");
            Book kirja = new Book("Twelve rules for life, an anditote for chaos", "Jordan Peterson", "Penguin Random House", 40.00);
            Book lehti = new Book("The subtle art of not giving a f*ck", "Mark Manson", "Atena", 14.90);
            kirja.FetchBook("Twelve rules for life, an anditote for chaos");
            kirja.Price = kirja.price;
            Book.SwitchTheme();
        }
    }
}
