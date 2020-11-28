using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MovieClient.Helper;
using MovieClient.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Threading.Tasks;
using System;
using System.Linq;

namespace MovieClient.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        MovieAPI _api = new MovieAPI();

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View("Index");
        }

        public async Task<IActionResult> AllMovies()
        {
            List<MovieData> movies = new List<MovieData>();
            HttpClient client = _api.Initial();
            HttpResponseMessage res = await client.GetAsync("api/Movies");
            if (res.IsSuccessStatusCode)
            {
                var results = res.Content.ReadAsStringAsync().Result;
                movies = JsonConvert.DeserializeObject<List<MovieData>>(results);
            }
            return View(movies);
        }

        [HttpPost]
        public async Task<IActionResult> AllMovies(string search)
        {
            // Get model from MovieApi
            List<MovieData> movies = new List<MovieData>();
            HttpClient client = _api.Initial();
            HttpResponseMessage res = await client.GetAsync("api/Movies");
            if (res.IsSuccessStatusCode)
            {
                var results = res.Content.ReadAsStringAsync().Result;
                movies = JsonConvert.DeserializeObject<List<MovieData>>(results);
            }

            // Search by Linq
            ViewData["MovieData"] = search;

            IEnumerable<MovieData> filter = null;
            if (!String.IsNullOrEmpty(search))
            {
                filter = movies.Where(m => m.Title.IndexOf(search, StringComparison.OrdinalIgnoreCase) != -1);
                return View(filter);
            }
            else
            {
                return View(movies);
            }
        }

        public async Task<IActionResult> TopMovies()
        {
            List<MovieData> movies = new List<MovieData>();
            HttpClient client = _api.Initial();
            HttpResponseMessage res = await client.GetAsync("api/Movies");
            if (res.IsSuccessStatusCode)
            {
                var results = res.Content.ReadAsStringAsync().Result;
                movies = JsonConvert.DeserializeObject<List<MovieData>>(results);
            }
            return View(movies);
        }

        public async Task<IActionResult> Details(int id)
        {
            var movies = new MovieData();
            HttpClient client = _api.Initial();
            HttpResponseMessage res = await client.GetAsync($"api/Movies/{id}");
            if (res.IsSuccessStatusCode)
            {
                var results = res.Content.ReadAsStringAsync().Result;
                movies = JsonConvert.DeserializeObject<MovieData>(results);
            }
            return View(movies);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(MovieData movie)
        {
            HttpClient client = _api.Initial();
            HttpResponseMessage res = await client.PostAsJsonAsync("api/Movies", movie);
            if (res.IsSuccessStatusCode)
            {
                return RedirectToAction("AllMovies");
            }
            return View();

            /*
            HttpClient client = _api.Initial();

            var postTask = client.PostAsJsonAsync("api/Movies", movie);
            postTask.Wait();

            var result = postTask.Result;
            if (result.IsSuccessStatusCode)
            {
                return RedirectToAction("AllMovies");
            }
            return View();
            */
        }

        public async Task<IActionResult> Edit(int id)
        {
            var movies = new MovieData();
            HttpClient client = _api.Initial();
            HttpResponseMessage res = await client.GetAsync($"api/Movies/{id}");
            if (res.IsSuccessStatusCode)
            {
                var results = res.Content.ReadAsStringAsync().Result;
                movies = JsonConvert.DeserializeObject<MovieData>(results);
            }
            return View(movies);

            /*
            HttpClient client = _api.Initial();

            var putTask = client.PutAsJsonAsync($"api/Movies/{id}", movie);
            putTask.Wait();

            var result = putTask.Result;
            if (result.IsSuccessStatusCode)
            {
                return RedirectToAction("AllMovies");
            }
            return View();
            */
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, MovieData movie)
        {
            HttpClient client = _api.Initial();
            HttpResponseMessage res = await client.PutAsJsonAsync($"api/Movies/{id}", movie);
            if (res.IsSuccessStatusCode)
            {
                return RedirectToAction("AllMovies");
            }
            return View();
        }

        public async Task<IActionResult> Delete(int id)
        {
            var movie = new MovieData();
            HttpClient client = _api.Initial();
            HttpResponseMessage res = await client.DeleteAsync($"api/Movies/{id}");

            return RedirectToAction("AllMovies");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Privacy()
        {
            return View("Privacy");
        }
    }
}
