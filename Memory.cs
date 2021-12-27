using System;
using System.Collections.Generic;

namespace VenConSort
{
     class Memory
    {
        public static           List<Song>  songList        =   new List<Song>();
        public static           List<Movie> movieList       =   new List<Movie>();
        public static readonly  string      MovielistPath   =   "Movies.jesus";
        public static readonly  string      SonglistPath    =   "Songs.jesus";      
        public static void DisplayAList(List<Song> movieList)
        {
            Console.Clear();
            foreach (Song item in movieList) { item.PrintEntry(); }
            Console.ReadKey();
        }
        public static void DisplayAList(List<Movie> movieList)
        {
            Console.Clear();
            foreach (Movie item in movieList) { item.PrintEntry(); }
            Console.ReadKey();
        }
    }
}
