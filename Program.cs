using System;
using System.Collections.Generic;
using System.IO;

namespace VenConSort
{
    class Program
    {
        static void Main()
        {
            FileService.Prepare(Memory.MovielistPath, Memory.SonglistPath);
            Console.Title = "VenConSort";
            Console.CursorVisible = false;
            while (true) { MainMenu.MenuChoice(); }
        }
    }
}