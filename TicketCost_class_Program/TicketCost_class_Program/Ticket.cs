using System;
using System.Collections.Generic;
using System.Text;

namespace TicketCost_class_Program
{
    class Ticket
    {
        public double cost;
        public double reduction;
        public string student;
        public string mtk;
        public string inService;
        public string age;
        public int number;

        public Ticket()
        {
            this.cost = 16;
            this.reduction= 0;
            this.student = "";
            this.mtk = "";
            this.inService = "";
            this.age = "";
        }
        public void QsAndAs()
        {
            Console.WriteLine("Are you a student? Type your answer: YES or NO.");
            this.student = Console.ReadLine();
            if (this.student.ToLower() == "yes")
            {
                this.reduction = 45;
            }

            Console.WriteLine("Are you a member of MTK? Type your ansver: YES or NO.");  
            this.mtk = Console.ReadLine();
            if (this.mtk.ToLower() == "yes")
            {
                this.reduction += 15;
            }

            Console.WriteLine("Are you a serviceman? Type your answer: YES or NO.");
            this.inService = Console.ReadLine();
            if (this.inService.ToLower() == "yes")
            {
                this.reduction = 50;
            }

            Console.WriteLine("Give your age in years. Answer with numbers please.");
            age = Console.ReadLine();
            while (!Int32.TryParse(this.age, out number))
            {
                Console.WriteLine($"Your age can not be '{this.age}' ,stupedo.");
                Console.WriteLine("Type your age in numbers please.");
                this.age = Console.ReadLine();
            }

        }
        public void CalculatePrice()
        {
            if (number < 8)
            {
                this.reduction = 100;
            }
            else if (number > 64)
            {
                this.reduction = 50;
            }
            else if (number > 7 && number < 65)
            {
                this.cost = 16;
            }

            this.cost = (100 - this.reduction) * this.cost / 100;

            if (this.reduction == 0)
            {
                this.cost = 16;
            }
            Console.WriteLine($"Your ticket price is {this.cost:f}e.");
        }
    }
}
