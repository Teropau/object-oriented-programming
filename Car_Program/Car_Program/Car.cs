using System;
using System.Collections.Generic;
using System.Text;

namespace Car_Program
{
    class Car
    {
        string brand;
        double speed;
        public Car()
        {
            this.brand = "";
            this.speed = 0;
        }
        public void AskData()
        {
            Console.WriteLine("Syötä auton merkki (Ei mikään halpa romu kiitos):");
            this.brand = Console.ReadLine();
            Console.WriteLine($"Syötä auton {this.brand} nopeus (km/h):");
            this.speed = int.Parse(Console.ReadLine());
        }
        public string ShowCarInfo()
        {
            return $"Merkki: {this.brand} Nopeus: {this.speed} km/h";
        }
        public void Accelerate()
        {
            int gas = 0;
            do
            {
                Console.WriteLine($"Syötä vauhdin lisäys autolle {this.brand}:");
                gas = int.Parse(Console.ReadLine());
            } while (gas < 0);
            this.speed += gas;
        }
        public void Brake()
        {
            this.speed = this.speed * 0.9;
        }

    }
}
