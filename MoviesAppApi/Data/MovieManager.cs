namespace MoviesAppApi.Data

{

    public class MovieManager
    {
        public List<Movie> Movies { get; set; }
        public MovieManager()
        {
            Movies = new List<Movie>()
            {
                new() { Id=1,Title="Movie 1",Director="Mr X",Summary="Good Movie"},
            new() { Id = 2, Title = "Movie 1", Director = "Mr X", Summary = "Good Movie" },
            new() { Id = 3, Title = "Movie 1", Director = "Mr X", Summary = "Good Movie" },
            new() { Id = 4, Title = "Movie 1", Director = "Mr X", Summary = "Good Movie" },
            new() { Id = 5, Title = "Movie 1", Director = "Mr X", Summary = "Good Movie" }
            };
        }
        public Movie AddMovie(Movie movie)
        {
            movie.id = Movies.Count + 1;
            Movies.Add(movie);
            return movie;
        }
        public int DeleteMovie(int id)
        {
            var movie=Movies.FirstOrDefault(x => x.Id == id);
            if (movie != null)
                return 0;
            _ = Movies.Remove(movie);
               return 1;
        }
        

    }
}
