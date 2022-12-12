using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MoviesAppApi.Data;

namespace MoviesAppWebAPI
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private readonly ApplicationDbContext _db;
        public MovieController(ApplicationDbContext db)
        {
            _db = db;
        }
        [HttpGet]
        [ProducesResponseType(200)]
        [ProducesResponseType(404)]
        public async Task<ActionResult<IEnumerable<Movie>>> Get()
        {
            var movies = await _db.movies.ToListAsync();
            return Ok(movies);
        }



        [HttpGet("{id}")]
        //[ProducesDefaultResponseType(StatusCode.status404NotFound)]
        public async Task<Movie?> GetOne(int id)
        {
            return await _db.movies.FindAsync(id);
        }



        [HttpPost]
        public async Task<Movie> Post(Movie model)
        {
            if (!ModelState.IsValid)
                return model;



            var movie = new Movie()
            {
                Title = model.Title,
                Director = model.Director,
                Summary = model.Summary,
            };
            _db.movies.Add(movie);
            await _db.SaveChangesAsync();
            return movie;



        }
















        //[HttpGet]
        //public async Task<IEnumerable<Movie>> Get()
        //{
        //    return await db.Movies.ToListAsync();
        //}



        //[HttpPost]
        //public async Task<Movie> Post(Movie movie)
        //{
        //    db.Movies.Add(movie);
        //    await db.SaveChangesAsync();
        //    return movie;
        //}
    }
}