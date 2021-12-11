using System;

namespace VenConSort
{
    class Program
    {
        static void Main(string[] args)
        {
            FileService.Initialize(Memory.MovielistPath, Memory.MovieList, Memory.SonglistPath, Memory.SongList);
            while (true)
            {
                MainMenu.MenuChoice();
            }
        }
    }
}