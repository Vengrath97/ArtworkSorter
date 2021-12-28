using System;
using System.Collections.Generic;

namespace VenConSort
{
    class Movie : Artwork
    {
        private string leadActor;
        public string LeadActor { get => leadActor; set => leadActor = value; }
        public Movie()
            :base()
        {
            Console.WriteLine("Proszę, wprowadź aktora:");
            LeadActor = (DataGather.InputMIN(1));
        }
        public Movie(string[] dane)
            :base()
        {
            LeadActor = dane[4];
        }
        public override string ToString()
        {
            return (this.Title + "," + this.Year + "," + this.Genre + "," + this.Artist + "," + this.LeadActor);
        }
        public override void PrintEntry()
        {
            Console.WriteLine(
                                $"Title:      { Title }\n" +
                                $"Genre:      { Genre }\n" +
                                $"By Artist:  { Artist }\n" +
                                $"Released:   { Year }\n" +
                                $"LeadActor:  { LeadActor }\n"
                                );
        }
        public static List<Movie> LoadFromFile(string FilePath)
        {
            List<Movie> artworklist = new List<Movie>();
            string[] ArtworkListFull = System.IO.File.ReadAllLines(FilePath);
            foreach (string item in ArtworkListFull)
            {
                string[] data = Artwork.DataSplit(item);
                artworklist.Add(new Movie(data));
            }
            return artworklist;
        }
    }
}