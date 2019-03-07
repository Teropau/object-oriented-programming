using System;
using System.Collections.Generic;
using System.Text;

namespace Car_Class_Program
{
    class Truck : Car
    {
        protected double cargoWeight;
        protected double gasConsumptionPerKg;

        public Truck()
        {
            this.cargoWeight = 0;
            this.gasConsumptionPerKg = 0;
        }

        public Truck(string engineSize, string engineModel, string doorsCount, string type, string brand, int year, double price, double cargoWeight, double gasConsumptionPerKg)
        {
            this.cargoWeight = cargoWeight;
            this.gasConsumptionPerKg = gasConsumptionPerKg;
        }

        public double CountConsumption()
        {
            return this.cargoWeight * this.gasConsumptionPerKg;
        }
        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Gas consumprion:{CountConsumption()}");
        }
    }
}
