﻿using BestMovies.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BestMovies.Controllers
{
    public class CustomersController : Controller
    {
        private List<Customer> _customers = new List<Customer>()
        {
            new Customer(){ Id = 1, FirstName = "Brad", LastName = "Pitt"},
            new Customer(){ Id = 2, FirstName = "Angelina", LastName = "Jolie"}
        };

        // GET: Customers
        public ActionResult Index()
        {
            return View(_customers);
        }

        // GET: Customers/Details/5
        public ActionResult Details(int id)
        {
            var customer = _customers.FirstOrDefault(c => c.Id == id);
            if (customer == null)
            {
                return HttpNotFound();
            }
            else
            {
                return View(customer);
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
