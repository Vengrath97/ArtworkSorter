using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VenConSort
{
    class Movie : Artwork
    {
        private string leadActor;
        public string LeadActor { get => leadActor; set => leadActor = value; }

        public Movie()
        {
            Console.Clear();
            Console.WriteLine("Proszę, wprowadź tytuł:");
            Title = (DataGather.InputMIN(1));
            Console.WriteLine("Proszę, wprowadź gatunek:");
            Genre = (DataGather.InputMIN(1));
            Console.WriteLine("Proszę, wprowadź twórcę:");
            Artist = (DataGather.InputMIN(1));
            Console.WriteLine("Proszę, wprowadź rok wydania:");
            Year = (DataGather.InputINT());
            Console.WriteLine("Proszę, wprowadź atkora:");
            LeadActor = (DataGather.InputMIN(1));
        }
        public Movie(string title, string genre, string artist, int year, string actor)
        {
            Title = title;
            Genre = genre;
            Artist = artist;
            Year = year;
            LeadActor = actor;
        }
        public Movie(string[] dane)
        {
            Title = dane[0];
            Genre = dane[1];
            Artist = dane[2];
            Year = int.Parse(dane[3]);
            LeadActor = dane[4];
        }
        public override void PrintEntry()
        {
            Console.WriteLine($"Title:      { Title }");
            Console.WriteLine($"Genre:      { Genre }");
            Console.WriteLine($"By Artist:  { Artist }");
            Console.WriteLine($"Released:   { Year }");
            Console.WriteLine($"LeadActor:   { LeadActor }\n");
        }
        public override string ToString()
        {
            return (this.Title + "," + this.Year + "," + this.Genre + "," + this.Artist + "," + this.LeadActor);
        }
    }
}
