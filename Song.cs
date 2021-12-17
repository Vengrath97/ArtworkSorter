using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace VenConSort
{
    class Song:Artwork
    {
        public Song()
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
        }
        public Song(string title, string genre, string artist, int year)
        {
            Title = title;
            Genre = genre;
            Artist = artist;
            Year = year;
        }
        public Song(string[] dane)
        {
            Title = dane[0];
            Genre = dane[1];
            Artist = dane[2];
            Year = int.Parse(dane[3]);
        }
        public override string ToString()
        {
            return (this.Title + "," + this.Year + "," + this.Genre + "," + this.Artist);
        }
        public override void PrintEntry()
        {
            Console.WriteLine($"Title:      { Title }");
            Console.WriteLine($"Genre:      { Genre }");
            Console.WriteLine($"By Artist:  { Artist }");
            Console.WriteLine($"Released:   { Year }\n");
        }
        public static List<Song> LoadFromFile(string FilePath)
        {
            List<Song> artworklist = new List<Song>();
            string[] ArtworkListFull = System.IO.File.ReadAllLines(FilePath);
            foreach (string item in ArtworkListFull)
            {
                string[] data = Artwork.DataSplit(item);
                artworklist.Add(new Song(data));
            }
            return artworklist;
        }
    }
}
