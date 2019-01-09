using System;
using System.Collections.Generic;
using System.Text;

namespace BookProgram
{
    class Book
    {
        public string title;
        public string author;
        public string id;
        public decimal price;
        public Book(string title, string author, string id, decimal price)
        {
            this.title = title;
            this.author = author;
            this.id = id;
            this.price = price;
        }
        public string PrintInfo()
        {
            return $"Nimi: {this.title} \nKirjailija: {this.author} \nid: {this.id} \nHinta: {this.price} \n";
        }
        public string BookCompare(Book book)
        {
            string text = "";
            if (this.price > book.price)
            {
                 text = $"Kirja {this.title} on kalliimpi, kuin {book.title}";
            }
            else if(this.price == book.price)
            {
                 text = $"Kirja {this.title} on samanhintainen, kuin {book.title}";
            }
            else
            {
                 text = $"Kirja {book.title} on kalliimpi, kuin {this.title}";
            }
            return text;
        }
    }
}
