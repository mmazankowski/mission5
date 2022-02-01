using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Mission5.Models;

namespace Mission5.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private MovieFormContext _mContext { get; set; }

        //Constructors

        public HomeController(ILogger<HomeController> logger, MovieFormContext someName)
        {
            _logger = logger;
            _mContext = someName;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult MyPodcasts()
        {
            return View(); 
        }

        [HttpGet]
        public IActionResult MovieForm()
        {
            ViewBag.Categories = _mContext.Categories.ToList();

            return View();
        }

        [HttpPost]
        public IActionResult MovieForm(FormResponses fr)
        {
            if (ModelState.IsValid)
            {
                _mContext.Add(fr);
                _mContext.SaveChanges();

                return View("Confirmation", fr);
            }
            else // If Invalid 
            {
                ViewBag.Categories = _mContext.Categories.ToList();

                return View(); 
            }
        }

        [HttpGet]
        public IActionResult MoviesList()
        {
            var movies = _mContext.Responses
                .Include(x => x.Category)
                .OrderBy(x => x.Title)
                .ToList();

            return View(movies); 
        }

        [HttpGet]
        public IActionResult Edit(int movieid)
        {
            ViewBag.Categories = _mContext.Categories.ToList();

            var movie = _mContext.Responses.Single(x => x.MovieId == movieid); 

            return View("MovieForm", movie);
        }

        [HttpPost]
        public IActionResult Edit(FormResponses fm)
        {
            _mContext.Update(fm);
            _mContext.SaveChanges();

            return RedirectToAction("MoviesList");
        }

        [HttpGet]
        public IActionResult Delete(int movieid)
        {
            _mContext.Responses.Single(x => x.MovieId == movieid); //this is where I am at 8:04 on video 6

            return View(); 
        }

        [HttpPost]
        public IActionResult Delete()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
