using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace MPHarjoitustyö
{
    class FileManager
    {
        private string filePath;
        private List<Movies> movieList;

        public FileManager(string filePath)
        {
            this.filePath = @"C:\\temp\movies.Json";
        }

        public void PrintAll()
        {
            movieList = JsonConvert.DeserializeObject<List<Movies>>(File.ReadAllText(this.filePath));

            foreach (Movies m in movieList)
            {
                Console.WriteLine($"----------\n" +
                    $"Nimi: {m.title} Vuosi: {m.year} Tyylilaji: {m.genre}");
            }
        }
        public void PrintMoviesByGenre()
        {
            movieList = JsonConvert.DeserializeObject<List<Movies>>(File.ReadAllText(this.filePath));
            string searchGenre = Console.ReadLine();
            foreach (Movies m in movieList)
            {
                if (m.genre == searchGenre)
                {
                    Console.WriteLine($"---------\n" +
                        $"Nimi: {m.title} Vuosi: {m.year} Tyylilaji: {m.genre}");
                }
            }
        }
        public void SearchByYear()
        {
            movieList = JsonConvert.DeserializeObject<List<Movies>>(File.ReadAllText(this.filePath));
            int searchYear = int.Parse(Console.ReadLine());
            foreach (Movies m in movieList)
            {
                if (m.year == searchYear)
                {
                    Console.WriteLine($"---------\n" +
                        $"Nimi: {m.title} Vuosi: {m.year} Tyylilaji: {m.genre}");
                }
            }
        }
        public void PrintMovieInfo()
        {
            movieList = JsonConvert.DeserializeObject<List<Movies>>(File.ReadAllText(this.filePath));
            string searchTitle = Console.ReadLine();
            foreach (Movies m in movieList)
            {
                if (m.title == searchTitle)
                {
                    Console.WriteLine($"---------\n" +
                        $"Nimi: {m.title} Vuosi: {m.year} Tyylilaji: {m.genre} \n" +
                        $"Näyttelijät: ");
                    for (int i = 0; i < m.cast.Count; i++)
                    {
                        Console.WriteLine(m.cast[i]);
                    }
                }
            }
        }
    }
}
