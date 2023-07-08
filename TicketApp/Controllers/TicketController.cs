using Microsoft.AspNetCore.Mvc;
using Service.Interface;

namespace TicketApp.Controllers
{
    public class TicketController : Controller
    {
        private readonly ITicketService _ticketService;

        public TicketController(ITicketService ticketService)
        {
            _ticketService = ticketService;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
