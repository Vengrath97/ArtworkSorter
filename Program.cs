using System;

namespace VenConSort
{
    class Program
    {
        static void Main()
        {
            Console.Title = "VenConSort";
            Console.CursorVisible = false;
            FileService.Prepare(Memory.MovielistPath, Memory.SonglistPath);
            while (true) { MainMenu.MenuChoice(); }
        }
    }
}