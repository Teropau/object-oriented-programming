using System;
namespace MPHarjoitustyö
{   
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Elokuvaluettelo");
            Console.WriteLine("Valitse toiminto\n" +
                "1: Tulosta koko lista \n" +
                "2: Tulosta lista Tyylilajin mukaan.\n" +
                "3: Tulosta tiettynä vuonna julkaistut elokuvat.");
            FileManager fm = new FileManager("lol");

            int caseSwitch = int.Parse(Console.ReadLine());
            switch (caseSwitch)
            {
                case 1:
                    Console.WriteLine("Tulostetaan koko lista.");
                    fm.PrintAll();
                    Console.WriteLine("Syötä Elokuvan nimi saadaksesi kaikki tiedot.");
                    fm.PrintMovieInfo();
                    break;
                case 2:
                    Console.WriteLine("Tulostetaan tyylilajin mukaan");
                    Console.Write("Kirjoita haettava tyylilaji:");
                    fm.PrintMoviesByGenre();
                    Console.WriteLine("Syötä Elokuvan nimi saadaksesi kaikki tiedot.");
                    fm.PrintMovieInfo();
                    break;
                case 3:
                    Console.WriteLine("Tulostetaan julkaisuvuoden mukaan.");
                    Console.Write("Kirjoita haettava vuosi:");
                    fm.SearchByYear();
                    Console.WriteLine("Syötä Elokuvan nimi saadaksesi kaikki tiedot.");
                    fm.PrintMovieInfo();
                    break;
            }
        }
    }
}
