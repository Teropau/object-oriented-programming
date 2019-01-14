using System;

namespace Car_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ralli");
            Car car1 = new Car();
            Car car2 = new Car();

            car1.AskData();
            car2.AskData();

            Console.WriteLine(car1.ShowCarInfo());
            Console.WriteLine(car2.ShowCarInfo());

            car1.Accelerate();
            car2.Accelerate();

            Console.WriteLine(car1.ShowCarInfo());
            Console.WriteLine(car2.ShowCarInfo());
            Console.WriteLine("Jarrutus");
            car1.Brake();
            car2.Brake();

            Console.WriteLine(car1.ShowCarInfo());
            Console.WriteLine(car2.ShowCarInfo());
        }
    }
}
