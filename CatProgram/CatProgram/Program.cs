using System;

namespace CatProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is a cat program.");
            Cat myFirstCat = new Cat("Mr.Nancy", 1);
            myFirstCat.weight = 5;
            Console.WriteLine($"Kissaa on syötetty. Uusi painoon. {myFirstCat.weight}");
            Cat mySecondCat = new Cat("Mittens", 3);
            Console.WriteLine("press any key to continue...");
            Console.ReadKey();
        }
    }
}
