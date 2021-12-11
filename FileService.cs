using System;
using System.Collections.Generic;
using System.IO;

namespace VenConSort
{
    class FileService
    {
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
        public static void OLDSaveMemoryAsFile(string FilePath, List<Artwork> List)
        {
            File.WriteAllText(FilePath, "");
            foreach (Artwork item in List)
            {
                File.AppendAllText(FilePath, item.GetTitle());
                File.AppendAllText(FilePath, "\n");
                File.AppendAllText(FilePath, item.GetYear().ToString());
                File.AppendAllText(FilePath, "\n");
                File.AppendAllText(FilePath, item.GetGenre());
                File.AppendAllText(FilePath, "\n");
                File.AppendAllText(FilePath, item.GetArtist());
                File.AppendAllText(FilePath, "\n");
            }
        }
        public static void SaveMemoryAsFile(string FilePath, List<Artwork> List)
        {
            File.WriteAllText(FilePath, "");
            foreach (Artwork item in List)
            {
                string temp = Converter.ToString(item) + "\n";
                File.AppendAllText(FilePath, temp);
            }
        }
        public static List<Artwork> LoadMoviesFromFile(string FilePath, List<Artwork> artworklist)
        {
            string[] ArtworkListFull = System.IO.File.ReadAllLines(FilePath);
            foreach (string item in ArtworkListFull)
            {
                string[] data = Converter.DataSpliter(item);
                artworklist.Add(new Movie(data));
            }
            return artworklist;
        }
        public static List<Artwork> OLDLoadMoviesFromFile(string FilePath, List<Artwork> artworklist)
        {
            string[] ArtworkListFull = System.IO.File.ReadAllLines(FilePath);
            for (int i = 0; 4 * i < ArtworkListFull.Length; i += 1)
            {
                artworklist.Add(new Movie());
                artworklist[i].SetTitle(ArtworkListFull[4 * i]);
                artworklist[i].SetYear(int.Parse(ArtworkListFull[4 * i + 1]));
                artworklist[i].SetGenre(ArtworkListFull[4 * i + 2]);
                artworklist[i].SetArtist(ArtworkListFull[4 * i + 3]);
            }
            return artworklist;
        }
        public static List<Artwork> LoadSongsFromFile(string FilePath, List<Artwork> artworklist)
        {
            string[] ArtworkListFull = System.IO.File.ReadAllLines(FilePath);
            foreach (string item in ArtworkListFull)
            {
                string[] data = Converter.DataSpliter(item);
                artworklist.Add(new Song(data));
            }
            return artworklist;
        }
        public static List<Artwork> OLDLoadSongsFromFile(string FilePath, List<Artwork> artworklist)
        {
            string[] ArtworkListFull = System.IO.File.ReadAllLines(FilePath);
            for (int i = 0; 4 * i < ArtworkListFull.Length; i += 1)
            {
                artworklist.Add(new Song());
                artworklist[i].SetTitle(ArtworkListFull[4 * i]);
                artworklist[i].SetYear(int.Parse(ArtworkListFull[4 * i + 1]));
                artworklist[i].SetGenre(ArtworkListFull[4 * i + 2]);
                artworklist[i].SetArtist(ArtworkListFull[4 * i + 3]);
            }
            return artworklist;
        }

        public static void Initialize(string MovielistPath, List<Artwork> MovieList, string SonglistPath, List<Artwork> SongList)
        {
            FileCheck(MovielistPath);
            FileCheck(SonglistPath);
            LoadMoviesFromFile(MovielistPath, MovieList);
            LoadSongsFromFile(SonglistPath, SongList);
        }
    }
}
