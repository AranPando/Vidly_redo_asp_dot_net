using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VidlyRedo.Models;

namespace VidlyRedo.Managers
{
    public class MovieManager
    {
        private List<Movie> Movies;

        public MovieManager()
        {
            this.Movies = new List<Movie>();
        }

        public List<Movie> GetMovies()
        {
            return this.Movies;
        }

        public Movie AddMovie(int id, string name, string year)
        {
            if (id < 0 || String.IsNullOrWhiteSpace(name)) return null;

            Movie movie = new Movie(id, name, year);

            this.Movies.Add(movie);

            return movie;

        }

        public Movie GetMovieName(string name)
        {
            if (string.IsNullOrWhiteSpace(name)) return null;
            foreach (var movie in Movies)
                if (movie.name == name) return movie;
            return null;
        }
    }
}