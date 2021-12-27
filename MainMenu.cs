using System;

namespace VenConSort
{
    class MainMenu
    {
        static readonly int firstRow            = 1;
        static readonly int optionCount         = 10;
        static          int currentCursorHeight = firstRow;
        static void DisplayMain()
        {
            Console.Clear();
            Console.WriteLine(
                                " === Witaj w Aplikacji! ===\n" +
                                "   Wybierz 1 by dodać film\n" +
                                "   Wybierz 2 by wyświetlić dane filmów\n" +
                                "   Wybierz 3 by dodać piosenke\n" +
                                "   Wybierz 4 by wyświetlić dane piosenek\n" +
                                "   Wybierz 5 by stracić postęp edycji filmów\n" +
                                "   Wybierz 6 by stracić postęp edycji piosenek\n" +
                                "   Wybierz 7 by zapisać dane o filmach do pliku\n" +
                                "   Wybierz 8 by zapisać dane o piosenkach do pliku\n" +
                                "   Wybierz 9 by wyzerować plik z danymi o filmach\n" +
                                "   Wybierz 10 by wyzerować plik z danymi o piosenkach\n"
                                );
        }
        static void DrawCursor(int height)
        {
            Console.SetCursorPosition(0, height);
            Console.Write(">");
        }
        static void CursorUp()
        {
            if (currentCursorHeight == firstRow) currentCursorHeight = optionCount;
            else currentCursorHeight -= 1;
        }
        static void CursorDown()
        {
            if (currentCursorHeight == optionCount) currentCursorHeight = firstRow;
            else currentCursorHeight += 1;
        }
        static ConsoleKey GetKey()
        {
            ConsoleKeyInfo keyInfo = Console.ReadKey(true);
            return keyInfo.Key;
        }
        public static void MenuChoice()
        {
            DisplayMain();
            DrawCursor(currentCursorHeight);
            switch (GetKey())
            {
                case ConsoleKey.UpArrow:    { CursorUp();                       break; }
                case ConsoleKey.DownArrow:  { CursorDown();                     break; }
                case ConsoleKey.Enter:      { RunChoice(currentCursorHeight);   break; }
                default:                    {                                   break; }
            }
        }
        public static void RunChoice(int choice)
        {
            switch (choice) 
            {
                case 1:  { Addmovie();           break; }
                case 2:  { Displaymovies();      break; }
                case 3:  { Addsong();            break; }
                case 4:  { Displaysongs();       break; }
                case 5:  { LoseProgressMovies(); break; }
                case 6:  { LoseProgressSongs();  break; }
                case 7:  { Savemovies();         break; }
                case 8:  { Savesongs();          break; }
                case 9:  { EreaseMovieSave();    break; }
                case 10: { EreaseSongSave();     break; }
                default: {                       break; }
            }
        }
        static void Addmovie()
        {
            Memory.movieList.Add(new Movie());
        }
        static void Addsong()
        {
            Memory.songList.Add(new Song());
        }
        static void Displaymovies()
        {
            Memory.DisplayAList(Memory.movieList);
        }
        static void Displaysongs()
        {
            Memory.DisplayAList(Memory.songList);
        }
        static void LoseProgressMovies()
        {
            Memory.movieList.Clear();
            Movie.LoadFromFile(Memory.MovielistPath);
        }
        static void LoseProgressSongs()
        {
            Memory.songList.Clear(); 
            Song.LoadFromFile(Memory.SonglistPath);
        }
        static void Savemovies()
        {
            FileService.SaveAsFile(Memory.movieList, Memory.MovielistPath);
        }
        static void Savesongs()
        {
            FileService.SaveAsFile(Memory.songList, Memory.SonglistPath);
        }
        static void EreaseMovieSave()
        {
            FileService.ClearFile(Memory.MovielistPath);
        }
        static void EreaseSongSave()
        {
            FileService.ClearFile(Memory.SonglistPath);
        }    
    }
}