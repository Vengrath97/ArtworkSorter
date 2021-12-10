using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VenConSort
{
    class MemoryService
    {
        public static void DisplayFullList(List<Artwork> Displaylist)
        {
            Console.Clear();
            foreach (Artwork item in Displaylist)
            {
                ArtworkService.DisplayFullInfo(item);
                Console.WriteLine("");
            }
            Console.ReadKey();
        }
        public static void AddMovie(List<Artwork> List)
        {
            List.Add(new Song());
            ArtworkService.GatherDataWizard(List[List.Count() - 1]);
        }
        public static void AddSong(List<Artwork> List)
        {
            List.Add(new Song());
            ArtworkService.GatherDataWizard(List[List.Count() - 1]);
        }
    }
}
