using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VenConSort
{
    class Song : Artwork
    {
        public Song()
        {

        }
        public Song(string[] dane)
        {
            SetTitle(dane[0]);
            SetYear(int.Parse(dane[1]));
            SetGenre(dane[2]);
            SetArtist(dane[3]);
        }
    }
}
