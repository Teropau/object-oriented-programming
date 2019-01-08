using System;
using System.Collections.Generic;
using System.Text;

namespace CatProgram
{
    public class Cat
    {
        public string name;
        public int weight;
        public Cat()
        {
            this.weight = 1;
            //Console.WriteLine($"Kissan paino on {this.weight}");
        }
        public Cat(string name, int weightValue)
        {
            this.name = name;
            this.weight = weightValue;
        }
        public Cat(int weightValue)
        {
            this.weight = weightValue;
            //Console.WriteLine($"Kissan paino on {this.weight}");
        }
        public void PrintWeight()
        {
            Console.WriteLine($"Kissan paino on {this.weight}");
        }
    }
}
