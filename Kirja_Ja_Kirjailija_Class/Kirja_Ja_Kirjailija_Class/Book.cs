using System;
using System.Collections.Generic;
using System.Text;

namespace Kirja_Ja_Kirjailija_Class
{
    class Book
    {
        public string name;
        public string author;
        public string publisher;
        public double price;
        public static string theme;

        /// <summary>
        /// nimi, kirjailija, Kustantaja, hinta
        /// </summary>
        public Book()
        {
            this.name = "";
            this.author = "";
            this.publisher = "";
            this.price = 0;
        }

        public Book(string name, string author, string publisher, double price)
        {
            this.name = name;
            this.author = author;
            this.publisher = publisher;
            this.price = price;
        }
        /// <summary>
        /// nimi
        /// </summary>
        /// <param name="name"></param>
        public void FetchBook(string name)
        {
            if (this.name == name)
            {
                Console.WriteLine($"Nimi:{this.name}\n" +
                    $"Kirjailija:{this.author}\n" +
                    $"Kustantaja:{this.publisher}\n" +
                    $"Hinta:{this.price:C}\n" +
                    $"Teema:{theme}");
            }
            else
            {
                Console.WriteLine("Kirjaa ei löytynyt.");
            }
        }

        public static void SwitchTheme()
        {
            Console.Write("Syötä uusi teema:");
            theme = Console.ReadLine();
        }

        public double Price
        {
            get { return price; }

            set
            {
                if (price > 30)
                {
                    Console.WriteLine($"Uusi hinta on: {price * 0.9:C}");
                }                   
            }
        }      
    }
}
