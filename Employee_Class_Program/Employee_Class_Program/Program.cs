using System;

namespace Employee_Class_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee[] employees = new Employee[3];

            employees[0] = new Employee ("J.Järvinen", 1, "Rakennuskosmetoloogi", 5000);
            employees[1] = new Employee("Mikko", 2, "Rakeennusmiäs", 2200);
            employees[2] = new Employee("Timo", 3, "Ragemaalari", 2400);
            foreach (Employee person in employees)
            {
                person.PrintEmployeeInfo();
            }
            employees[0].CompareSalary(employees[1]);
        }
    }
}
