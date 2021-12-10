using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VenConSort
{
    class Memory
    {
        public static List<Artwork> MovieList = new List<Artwork>();    //List of Song-Class objects
        public static string MovielistPath = "Movielist.txt";           //Filename for list of movies and their data

        public static List<Artwork> SongList = new List<Artwork>();     //List of Movie-Class objects
        public static string SonglistPath = "Songlist.txt";             //Filename for list of songs and their data
    }
}
