using System;
using System.Collections.Generic;

namespace VenConSort
{
    class Song:Artwork
    {
        public Song()
            :base()
        {
        }
        public Song(string[] dane)
            :base(dane)
        {

        }
        public override string ToString()
        {
            return (this.Title + "," + this.Year + "," + this.Genre + "," + this.Artist);
        }
        public override void PrintEntry()
        {
            Console.WriteLine(
                                $"Title:      { Title }\n" +
                                $"Genre:      { Genre }\n" +
                                $"By Artist:  { Artist }\n" +
                                $"Released:   { Year }\n"
                                );
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