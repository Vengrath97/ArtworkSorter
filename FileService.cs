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
        public static void Prepare(string movielistPath, string songlistPath)
        {
            FileCheck(movielistPath);
            FileCheck( songlistPath);
            Memory.movieList    =   Movie.LoadFromFile(Memory.MovielistPath);
            Memory.songList     =   Song.LoadFromFile (Memory.SonglistPath);
        }
        public static void FileCheck(string FilePath)
        {
            if (!File.Exists(FilePath)) { File.WriteAllText(FilePath, ""); }
        }
        public static void SaveAsFile(List<Song> list, string FilePath)
        {
            File.WriteAllText(FilePath, "");
            foreach (Song item in list) { File.AppendAllText(FilePath, item.ToString() + "\n"); }
        }
        public static void SaveAsFile(List<Movie> list, string FilePath)
        {
            File.WriteAllText(FilePath, "");
            foreach (Movie item in list) { File.AppendAllText(FilePath, item.ToString() + "\n"); }
        }
        public static void ClearFile(string FilePath)
        {
            File.WriteAllText(FilePath, "");
        }
    }
}