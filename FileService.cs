using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace VenConSort
{
    class FileService
    {
        public static void MakeSureAllFilesThatAreRequiredForThisProgramToWorkExistAndCreateThemIfTheyDontAndThenLoadDataThatIsContainedWithinThemToProgramMemory(string movielistPath, string songlistPath)
        {
            FileCheck(movielistPath);
            FileCheck(songlistPath);
            Memory.movieList = LoadMoviesFromFile(Memory.MovielistPath);
            LoadSongsFromFile(Memory.SonglistPath, Memory.songList);
        }
        public static void FileCheck(string FilePath)
        {
            if (!File.Exists(FilePath)) 
            {
                File.WriteAllText(FilePath, ""); 
            }
        }
        public static void PrintFile(string FilePath)
        {
            Console.Clear();
            string[] movielistFull = System.IO.File.ReadAllLines(FilePath);
            for (int a = 0; a < movielistFull.Length; a++)
            {
                Console.WriteLine(movielistFull[a]);
            }
            Console.ReadKey();
        }
        public static void SaveAsFile(List<Song> list, string FilePath)
        {
            File.WriteAllText(FilePath, "");
            foreach (Song item in list)
            {
                File.AppendAllText(FilePath, item.ToString() + "\n");
            }
        }
        public static void SaveAsFile(List<Movie> list, string FilePath)
        {
            File.WriteAllText(FilePath, "");
            foreach (Movie item in list)
            {
                File.AppendAllText(FilePath, item.ToString() + "\n");
            }
        }
        public static List<Movie> LoadMoviesFromFile(string FilePath)
        {
            List<Movie> artworklist = new List<Movie>() ;
            string[] ArtworkListFull = System.IO.File.ReadAllLines(FilePath);
            foreach (string item in ArtworkListFull)
            {
                string[] data = Artwork.DataSplit(item);
                artworklist.Add(new Movie(data));
            }
            return artworklist;
        }

        public static List<Song> LoadSongsFromFile(string FilePath, List<Song> artworklist)
        {
            string[] ArtworkListFull = System.IO.File.ReadAllLines(FilePath);
            foreach (string item in ArtworkListFull)
            {
                string[] data = Artwork.DataSplit(item);
                artworklist.Add(new Song(data));
            }
            return artworklist;
        }
    }
}
