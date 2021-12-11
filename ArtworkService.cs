using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VenConSort
{
    class ArtworkService
    {
        public static void DisplayFullInfo(Artwork Object)
        {
            Console.WriteLine($"Title:      { Object.GetTitle() }");
            Console.WriteLine($"Released:   { Object.GetYear() }");
            Console.WriteLine($"Genre:      { Object.GetGenre() }");
            Console.WriteLine($"By Artist:  { Object.GetArtist() }");
        }
        public static void GatherDataWizard(Artwork Object)
        {
            Console.Clear();
            Console.WriteLine("Proszę, wprowadź tytuł:");
            Object.SetTitle(DataCollector.DataMin(1));
            Console.WriteLine("Proszę, wprowadź rok wydania:");
            Object.SetYear(DataCollector.DataInt());
            Console.WriteLine("Proszę, wprowadź gatunek:");
            Object.SetGenre(DataCollector.DataMin(1));
            Console.WriteLine("Proszę, wprowadź twórcę:");
            Object.SetArtist(DataCollector.DataMin(1));
        }
    }
}
