using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                                " > Wybierz 4 by wyświetlić dane piosenke\n" +
                                " > Wybierz 5 by stracić postęp edycji filmów\n" +
                                " > Wybierz 6 by stracić postęp edycji piosenek\n" +
                                " > Wybierz 7 by wyświetlić zawartość pliku z danymi o filmach\n" +
                                " > Wybierz 8 by wyświetlić zawartość pliku z danymi o piosenkach\n" +
                                " > Wybierz 9 by zapisać dane o filmach do pliku\n" +
                                " > Wybierz 10 by zapisać dane o piosenkach do pliku\n" +
                                " > Wybierz 11 by wyzerować plik z danymi o filmach\n" +
                                " > Wybierz 12 by wyzerować plik z danymi o piosenkach\n"
                                );
            return DataCollector.DataInt();
        }
        public static void MenuChoice()
        {
            switch (DisplayMain())
            {
                case 1: { MemoryService.AddMovie(Memory.MovieList);         break; }    // Creates a new Movie-type Entry and adds it on the end of the MovieListName
                case 2: { MemoryService.DisplayFullList(Memory.MovieList);  break; }    // Displays all Movie-type Entries from memory
                case 3: { MemoryService.AddSong(Memory.SongList);           break; }    // Creates a new Song-type Entry and adds it on the end of the SongListName
                case 4: { MemoryService.DisplayFullList(Memory.SongList);   break; }    // Displays all Song-type Entries from memory
                case 5: { Memory.MovieList.Clear(); Memory.MovieList = FileService.LoadMoviesFromFile(Memory.MovielistPath, Memory.MovieList); break; } // Loads data about Movies from savefile to aplication memory. Does not save current progress.
                case 6: { Memory.SongList = FileService.LoadSongsFromFile(Memory.SonglistPath, Memory.SongList);   break; }  // Loads data about Songs  from savefile to aplication memory. Does not save current progress.
                case 7: { FileService.PrintFile(Memory.MovielistPath);      break; }    // Prints data about Movies directly from savefile, without losing progress.
                case 8: { FileService.PrintFile(Memory.SonglistPath);       break; }    // Prints data about Songs directly from savefile, without losing progress.
                case 9: { FileService.SaveMemoryAsFile(Memory.MovielistPath, Memory.MovieList); break; }    // Saves data about Movies from memory to savefile
                case 10: { FileService.SaveMemoryAsFile(Memory.SonglistPath, Memory.SongList); break; }    // Saves data about Songs from memory to savefile
                case 11: { System.IO.File.WriteAllText(Memory.MovielistPath, ""); break; }    // Saves data about Songs from memory to savefile
                case 12: { System.IO.File.WriteAllText(Memory.SonglistPath, ""); break; }    // Saves data about Songs from memory to savefile
                default: { Console.WriteLine("Brak Opcji!"); Console.ReadKey(); break; }    // Displays error when an option choosen does not match the available options
            }
        }

    }
}
