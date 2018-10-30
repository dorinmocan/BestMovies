using BestMovies.DB;
using BestMovies.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BestMovies.Controllers
{
    public class MoviesController : Controller
    {
        private BestMoviesDBContext _bestMoviesDBContext = new BestMoviesDBContext();

        // GET: Movies
        public ActionResult Index()
        {
            var movies = _bestMoviesDBContext.Movies.ToList();
            return View(movies);
        }

        // GET: Movies/Details/5
        public ActionResult Details(int id)
        {
            var movie = _bestMoviesDBContext.Movies.FirstOrDefault(m => m.Id == id);
            if (movie == null)
            {
                return HttpNotFound();
            }
            else
            {
                return View(movie);
            }
        }

        // GET: Customers/Create
        public ActionResult Create()
        {
            var movieCreationModel = new MovieCreateEditModel()
            {
                Genres = _bestMoviesDBContext.Genres.Select(g => g.Name).ToList()
            };
            return View(movieCreationModel);
        }

        // POST: Customers/Create
        [HttpPost]
        public ActionResult Create(MovieCreateEditModel movieCreateModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var genre = _bestMoviesDBContext.Genres.FirstOrDefault(g => g.Name == movieCreateModel.Genre);
                    var movie = new Movie()
                    {
                        Title = movieCreateModel.Title,
                        Genre = genre,
                        ReleaseDate = movieCreateModel.ReleaseDate,
                        AddedOn = DateTime.Now,
                        NumberInStock = movieCreateModel.NumberInStock
                    };

                    _bestMoviesDBContext.Movies.Add(movie);
                    _bestMoviesDBContext.SaveChanges();
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Customers/Edit/5
        public ActionResult Edit(int id)
        {
            var movie = _bestMoviesDBContext.Movies.Find(id);
            var movieEditModel = new MovieCreateEditModel()
            {
                Title = movie.Title,
                Genre = movie.Genre.Name,
                ReleaseDate = movie.ReleaseDate,
                NumberInStock = movie.NumberInStock,
                Genres = _bestMoviesDBContext.Genres.Where(g => g.Name != movie.Genre.Name).Select(g => g.Name).ToList()
            };
            return View(movieEditModel);
        }

        // POST: Customers/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, MovieCreateEditModel movieEditModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var genre = _bestMoviesDBContext.Genres.FirstOrDefault(g => g.Name == movieEditModel.Genre);
                    var movie = _bestMoviesDBContext.Movies.Find(id);
                    movie.Title = movieEditModel.Title;
                    movie.Genre = genre;
                    movie.ReleaseDate = movieEditModel.ReleaseDate;
                    movie.NumberInStock = movieEditModel.NumberInStock;

                    _bestMoviesDBContext.Entry(movie).State = EntityState.Modified;
                    _bestMoviesDBContext.SaveChanges();
                }
                
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Customers/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Customers/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
