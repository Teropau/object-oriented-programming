using System;

namespace CatProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is a cat program.");
            Cat myFirstCat = new Cat("Mr.Nancy", 1);
            myFirstCat.InkreaseWeight(1);
            myFirstCat.PrintWeight();
            Console.WriteLine("---------------------------");
            Cat mySecondCat = new Cat("Mittens", 3);
            mySecondCat.PrintWeight();
            Console.WriteLine("press any key to continue...");
            Console.ReadKey();
        }
    }
}
