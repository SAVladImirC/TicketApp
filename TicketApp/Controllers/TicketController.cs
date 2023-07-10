using Domain.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Service.Interface;

namespace TicketApp.Controllers
{
    public class TicketController : Controller
    {
        private readonly ITicketService _ticketService;
        private readonly IMovieService _moviesService;

        public TicketController(ITicketService ticketService, IMovieService moviesService)
        {
            _ticketService = ticketService;
            _moviesService = moviesService;
        }

        public ActionResult Index()
        {
            return View(_ticketService.GetAll().Result);
        }

        public ActionResult Details(int id)
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            List<Movie> movies = await _moviesService.GetAll();
            ViewBag.MovieList = new SelectList(movies, "Id", "Name");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create( Ticket ticket)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    ticket = await _ticketService.Insert(ticket);
                    return RedirectToAction(nameof(Index));
                }

                return View(ticket);
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Edit(int id)
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Delete(int id)
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
