using System;
using System.Collections.Generic;
using System.Text;

namespace Car_Class_Program
{
    abstract class Vehicle
    {
        protected string type;
        protected string brand;
        protected int year;
        protected double price;
        
        public Vehicle()
        {
            this.type = "Oletus";
            this.brand = "Oletus";
            this.year = 0;
            this.price = 0;
        }
        public Vehicle(string type, string brand, int year, double price)
        {
            this.type = type;
            this.brand = brand;
            this.year = year;
            this.price = price;
        }
        public virtual void PrintInfo()
        {
            Console.WriteLine($"Tyyppi: {this.type}\n" +
                $"Merkki: {this.brand}\n" +
                $"Vuosimalli: {this.year}\n" +
                $"Hinta: {this.price:C}");
        }
    }
}
