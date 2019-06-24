using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VidlyRedo.Models;
using VidlyRedo.ViewModels;

namespace VidlyRedo.Controllers
{
    public class MoviesController : Controller  
    {
        [Route("movies")]
        public ActionResult Index()
        {
            IndexMovieViewModel movies = new IndexMovieViewModel();
            movies.Movies = GlobalVariables.GetMovies();
            return View(movies);
        }

        [Route("movies/{name}")]
        public ActionResult ViewMovie(string name)
        {
            Movie Mov = GlobalVariables.GetMovieName(name);
            if (Mov == null) return HttpNotFound("Invalid Movie name");
            return View(Mov);
        }

        [Route("movies/add/{id}/{name}/{year}")]
        public ActionResult AddMovie(int id, string name, string year)
        {
            Movie Mov = GlobalVariables.AddMovie(id, name, year);
            if (Mov == null) return HttpNotFound("Bad Movie info");
            return RedirectToAction("Index");
        }

        // GET: Movies/Random
        //public ViewResult Random()
        //{
        //    string curr_year = DateTime.Now.Year.ToString();

        //    var movie = new Movie() { id = 1, name = "Potato", year = "2019" };

        //    var customers = new List<Customer>
        //    {
        //        new Customer {name = "David" },
        //        new Customer {name = "Josh" }
        //    };

        //    var movi_view_model = new RandomMovieViewModel
        //    {
        //        movie = movie,
        //        customers = customers
        //    };

        //    return View(movi_view_model);
        //}
        //// GET: movies/edit/{id}
        //public ActionResult Edit(int id)
        //{
        //    return Content("id = " + id);
        //}

        //// movies/
        //public ActionResult Index(int? page_index, string sort_by)
        //{
        //    if (!page_index.HasValue) page_index = 1;
        //    if (String.IsNullOrWhiteSpace(sort_by)) sort_by = "name";

        //    return Content(String.Format("page index = {0}, sort by = {1}", page_index, sort_by));
        //}

        //// movies/release/{year}/{month}
        //[Route("movies/released/{year:regex(\\d{4}):range(1888,2019)}/{month:regex(\\d{2}):range(1,12)}")]
        //public ActionResult ByReleaseDAte( int year, int month)
        //{
        //    return Content(year + "/" + month);
        //}
    }
}