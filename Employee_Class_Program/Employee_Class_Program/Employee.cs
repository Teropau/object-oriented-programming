using System;
using System.Collections.Generic;
using System.Text;

namespace Employee_Class_Program
{
    class Employee
    {
        public string name;
        public int id = 0;
        public string position;
        public double salary;

        /// <summary>
        /// name, id, position, salary
        /// </summary>
        /// <param name="name"></param>
        /// <param name="id"></param>
        /// <param name="position"></param>
        /// <param name="salary"></param>
        public Employee()
        {
            this.name = "Ei nimeä";
            this.id = 0;
            this.position = "Ei tehtävää";
            this.salary = 0;
        }

        public Employee(string name, int id, string position, double salary)
        {
            this.name = name;
            this.id = id;
            this.position = position;
            this.salary = salary;
        }
        public void PrintEmployeeInfo()
        {

            Console.WriteLine($"Nimi:{this.name}, Id:{this.id}, Tehtävä:{this.position}, Palkka:{this.salary:f}e");
        }
        public void CompareSalary(Employee person)
        {
            if (this.salary > person.salary)
            {
                Console.WriteLine($"Duunarin: {this.name} palkka: {this.salary} on suurempi, kuin duunarin:{person.name} palkka: {person.salary}.");
            }
            else if (this.salary < person.salary)
            {
                Console.WriteLine($"Duunarin: {this.name} palkka: {this.salary} on pienempi, kuin duunarin:{person.name} palkka: {person.salary}.");
            }
            else
            {
                Console.WriteLine($"Duunarin: {this.name} palkka: {this.salary} on sama, kuin duunarin:{person.name} palkka: {person.salary}.");
            }
        }
    }
}
