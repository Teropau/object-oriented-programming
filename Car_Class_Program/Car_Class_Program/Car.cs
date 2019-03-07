using System;
using System.Collections.Generic;
using System.Text;

namespace Car_Class_Program
{
    class Car : Vehicle
    {
        protected string engineSize;
        protected string engineModel;
        protected string doorsCount;

        public Car()
        {
            this.engineSize = "";
            this.engineModel = "";
            this.doorsCount = "";
        }
    
        public Car(string engineSize, string engineModel, string doorsCount, string type, string brand, int year, double price):
            base(type, brand, year, price)
        {
            this.engineSize = engineSize;
            this.engineModel = engineModel;
            this.doorsCount = doorsCount;
        }
        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Koneen koko: {this.engineSize}\n" +
                $"Koneen malli: {this.engineModel}\n" +
                $"Ovien määrä: {this.doorsCount}");
        }
        public override string ToString()
        {
            return base.ToString();
        }
        public override bool Equals(object obj)
        {           
            return base.Equals(obj);
        }
    }
}
