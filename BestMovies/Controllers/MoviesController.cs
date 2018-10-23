﻿using BestMovies.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BestMovies.Controllers
{
    public class MoviesController : Controller
    {
        private List<Movie> _movies = new List<Movie>()
        {
            new Movie(){ Id = 1, Title = "Shrek!"},
            new Movie(){ Id = 2, Title = "Mr. and Msr. Smith"}
        };

        // GET: Movies
        public ActionResult Index()
        {
            return View(_movies);
        }

        // GET: Movies/Details/5
        public ActionResult Details(int id)
        {
            var movies = _movies.FirstOrDefault(m => m.Id == id);
            if (movies == null)
            {
                return HttpNotFound();
            }
            else
            {
                return View(movies);
            }
        }

        // GET: Customers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Customers/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

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
            return View();
        }

        // POST: Customers/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

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
