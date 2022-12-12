namespace MoviesAppApi.Data
{
    public class Movie
    {
        internal static int count;
        internal object id;

        public  int Id { get; set; }
        public string Title { get; set; }
        public string Director { get; set; }
        public string Summary { get; set; }
    }
}
