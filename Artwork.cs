using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VenConSort
{
    abstract class Artwork
    {
        string Title;
        int Year;
        string Genre;
        string Artist;
        public Artwork()
        {

    }
    public string GetTitle()
    {
        return (Title);
    }
    public void SetTitle(string NewTitle)
        {
            this.Title = NewTitle;
        }
        public string GetArtist()
        {
            return (Artist);
        }
        public void SetArtist(string NewArtist)
        {
            this.Artist = NewArtist;
        }
        public string GetGenre()
        {
            return (Genre);
        }
        public void SetGenre(string NewGenre)
        {
            this.Genre = NewGenre;
        }
        public int GetYear()
        {
            return (Year);
        }
        public void SetYear(int NewYear)
        {
            this.Year = NewYear;
        }
    }
}
