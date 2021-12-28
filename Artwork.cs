using System;

namespace VenConSort
{
    class Artwork
    {
        public  string  Title   { get => title; set => title = value; }
        private string  title;
        public  string  Genre   { get => genre; set => genre = value; }
        private string  genre;
        public  string  Artist  { get => artist; set => artist = value; }
        private string  artist;
        public  int     Year    { get => year; set => year = value; }
        private int     year;

        public Artwork()
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
        public Artwork(string[] dane)
        {
            Title = dane[0];
            Genre = dane[1];
            Artist = dane[2];
            Year = int.Parse(dane[3]);
        }
        public Artwork(string title, string genre, string artist, int year)
        {
            Title = title;
            Genre = genre;
            Artist = artist;
            Year = year;
        }
        public virtual void PrintEntry()
        {
        }
        public static string[] DataSplit(string fileLine)
        {
            return fileLine.Split(',');
        }
        public virtual string ToString(Artwork artwork)
        {
            return "Title,Genre,Artist,0000";
        }
    }
}