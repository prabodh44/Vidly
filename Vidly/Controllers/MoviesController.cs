﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Random()
        {
            var movie = new Movie() {Name = "Prabodh"};
            return View(movie);
        }

        public ActionResult Edit(int id)
        {
            return Content("id " + id);
        }

        public ActionResult Index (int? pageIndex, string sortBy)
        {
            //the ? in the datatype int tells the compiler that pageIndex can be nullable
            if (!pageIndex.HasValue)
            {
                pageIndex = 1;
            }

            if (String.IsNullOrWhiteSpace(sortBy))
            {
                sortBy = "Name";
            }

            return Content(String.Format("pageIndex={0}&sortBy={1}", pageIndex,sortBy));
        }

        [Route("movies/released/{year}/{month : regex(\\d{2}) : range(1,12)}")]
        public ActionResult ByReleasedDate(int year, int month)
        {
            return Content(year + " / " + month);
        }
    }

    
}