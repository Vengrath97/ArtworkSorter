using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VenConSort
{
    class Song : Artwork
    {
        string Title { get; set; }
        int Year { get; set; }
        string Genre { get; set; }
        string Artist { get; set; }
        public Song()
        {

        }
    }
}
