using System;

namespace BookProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kirjaohjelma");
            Book newBook = new Book("Ultimate history of Wood working around the world", "Carpenter Brut", "00001", 24);
            Console.WriteLine(newBook.PrintInfo());
            Book newBook2 = new Book("Aapinen", "Agricola", "00002", 12);
            Console.WriteLine(newBook2.PrintInfo());
            Console.WriteLine("------------------");
            Console.WriteLine(newBook.BookCompare(newBook2));
        }

    }
}
