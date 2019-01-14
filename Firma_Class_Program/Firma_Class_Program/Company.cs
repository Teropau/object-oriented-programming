using System;
using System.Collections.Generic;
using System.Text;

namespace Firma_Class_Program
{

    class Company
    {
        public string title;
        public string adress;
        public string phone;
        public double income;
        public double expense;

        public Company()
        {
            this.title = "Ei nimeä";
            this.adress = "Ei osoitetta";
            this.phone = "Ei puh. numeroa";
            this.income = 0;
            this.expense = 0;
        }
        /// <summary>
        /// title, adress, phone, income, expense
        /// </summary>
        public Company(string title, string adress, string phone, double income, double expense)
        {
            this.title = title;
            this.adress = adress;
            this.phone = phone;
            this.income = income;
            this.expense = expense;
        }
        public Company(Company previousCompany)
        {
            this.title = previousCompany.title;
            this.adress = previousCompany.adress;
            this.phone = previousCompany.phone;
            this.income = previousCompany.income;
            this.expense = previousCompany.expense;
        }
        public void WinLossCounter()
        {           
            double outcomePercent = (this.income - this.expense) / this.expense * 100;
            Console.WriteLine($"Tulosprosentti on {outcomePercent:f0}%");
 
            if (outcomePercent < 100)
            {
                Console.WriteLine("Yrityksellä menee huonosti. Voitto on alle 100%");
            }
            else if (outcomePercent > 100 && outcomePercent < 200)
            {
                Console.WriteLine("Yrityksellä menee niinku menee ja antaa mennä, ku on mennäkseen.");
            }
            else if (outcomePercent < 300 && outcomePercent > 200)
            {
                Console.WriteLine("Yrityksellä menee kohtalaisesti. Voitto on yli 200%");
            }
            else if (outcomePercent > 300)
            {
                Console.WriteLine("Yrityksellä menee hyvin. Voitto on yli 300%");
            }
        }
    }
}
