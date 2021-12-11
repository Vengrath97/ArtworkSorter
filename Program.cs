using System;

namespace VenConSort
{
    class Program
    {
        static void Main(string[] args)
        {
            FileService.Initialize(Memory.MovielistPath, Memory.MovieList, Memory.SonglistPath, Memory.SongList);
            Console.ReadKey();
            while (true)
            {
                MainMenu.MenuChoice();
            }
        }
    }
}