using System;

namespace Car_Class_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kulkuneuvoja");
            Console.WriteLine("-----------");
            Car myCar = new Car("1", "Volvo", "5", "farmari", "Volvo", 1995, 3000);
            Console.WriteLine("Auto");
            myCar.PrintInfo();
            Console.WriteLine("------------");
            Truck yourCar = new Truck("2", "Volvo", "3", "Kuorma-auto", "Sisu", 1995, 3000, 2000, 30);
            yourCar.PrintInfo();
        }
    }
}
