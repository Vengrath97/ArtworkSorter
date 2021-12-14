using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VenConSort
{
     class Memory
    {
        public static List<Song> songList = new List<Song>();  //List of objects
        public static List<Movie> movieList = new List<Movie>();  //List of objects
        public static string MovielistPath = "Movies.css";          //Filename for list of movies and their data
        public static string SonglistPath = "Songs.css";            //Filename for list of songs and their data

        public static void DisplaySongs(List<Song> songList)
        {
            Console.Clear();
            foreach (Song item in songList)
            {
                item.PrintEntry();
            }
            Console.ReadKey();
        }
        public static void DisplayMovies(List<Movie> movieList)
        {
            Console.Clear();
            foreach (Movie item in movieList)
            {
                item.PrintEntry();
            }
            Console.ReadKey();
        }
    }
}
