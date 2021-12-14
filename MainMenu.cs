﻿using System;

namespace VenConSort
{
    class MainMenu
    {
        public static int DisplayMain()
        {
            Console.Clear();
            Console.WriteLine(
                                " === Witaj w Aplikacji! ===\n" +
                                " > Wybierz 1 by dodać film\n" +
                                " > Wybierz 2 by wyświetlić dane filmów\n" +
                                " > Wybierz 3 by dodać piosenke\n" +
                                " > Wybierz 4 by wyświetlić dane piosenek\n" +
                                " > Wybierz 5 by stracić postęp edycji filmów\n" +
                                " > Wybierz 6 by stracić postęp edycji piosenek\n" +
                                " > Wybierz 7 by zapisać dane o filmach do pliku\n" +
                                " > Wybierz 8 by zapisać dane o piosenkach do pliku\n" +
                                " > Wybierz 9 by wyzerować plik z danymi o filmach\n" +
                                " > Wybierz 10 by wyzerować plik z danymi o piosenkach\n"
                                );
            return DataGather.InputINT();
        }
        public static void MenuChoice()
        {
            switch (DisplayMain())
            {
                // Creates a new Movie-type Entry and adds it on the end of the MovieListName
                case 1: { Addmovie(); break; }
                // Displays all Movie-type Entries from memory
                case 2: { Displaymovies(); break; }
                // Creates a new Song-type Entry and adds it on the end of the SongListName
                case 3: { Addsong(); break; }
                // Displays all Song-type Entries from memory
                case 4: { Displaysongs(); break; }
                // Loads data about Movies from savefile to aplication memory. Does not save current progress.
                case 5: { LoseProgressMovies(); break; }
                // Loads data about Songs  from savefile to aplication memory. Does not save current progress.
                case 6: { LoseProgressSongs(); break; }
                // Saves data about Movies from memory to savefile
                case 7: { Savemovies(); break; }
                // Saves data about Songs from memory to savefile
                case 8: { Savesongs(); break; }
                // Displays error when an option choosen does not match the available options
                default: { Console.WriteLine(""); break; }

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
    }
}