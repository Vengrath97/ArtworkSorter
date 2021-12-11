using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VenConSort
{
    static class Converter
    {
        public static string ToString(Artwork obiekt)
        {
            string line = obiekt.GetTitle() + "," + obiekt.GetYear() + "," + obiekt.GetGenre() + "," + obiekt.GetArtist();
            return line;
        }
        public static string[] DataSpliter(string inString)
        {
            string[] components = inString.Split(',');
            return components;
        }
        public static void ToDisplay(List<Artwork> lista, int obiekt) // wywołanie to np.  Converter.ToDisplay(Memory.MovieList,0); by wydrukować kolejno dane dla obiektu
        {
            string a = Converter.ToString(lista[obiekt]);
            string[] arr = Converter.DataSpliter(a);
            foreach (string item in arr)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}