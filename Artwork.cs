namespace VenConSort
{
    class Artwork
    {
        public  string  Title   { get => title; set => title = value; }
        private string  title;
        public  string  Genre   { get => genre; set => genre = value; }
        private string  genre;
        public  string  Artist  { get => artist; set => artist = value; }
        private string  artist;
        public  int     Year    { get => year; set => year = value; }
        private int     year;

        public virtual void PrintEntry()
        {
        }
        public static string[] DataSplit(string fileLine)
        {
            return fileLine.Split(',');
        }
        public virtual string ToString(Artwork artwork)
        {
            return "Title,Genre,Artist,0000";
        }
    }
}