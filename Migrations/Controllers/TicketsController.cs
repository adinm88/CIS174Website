using Microsoft.AspNetCore.Mvc;
using PhoneWebApp.Models;

namespace PhoneWebApp.Controllers
{
    public class TicketsController : Controller
    {
        private static List<Ticket> tickets = new List<Ticket>
        {
            new Ticket { Id=1, Name="Create Base Page", Description="Basic layout", SprintNumber=1, PointValue=3, Status="To Do"},
            new Ticket { Id=2, Name="Add Decoration", Description="Decoration", SprintNumber=1, PointValue=5, Status="In Progress"},
            new Ticket { Id=3, Name="Testing", Description="QA checks", SprintNumber=2, PointValue=2, Status="QA"}
        };

        public IActionResult Index(string status = "All")
        {
            var vm = new TicketViewModel();

            vm.CurrentStatus = status;

            vm.Tickets = status == "All"
                ? tickets
                : tickets.Where(t => t.Status == status).ToList();

            return View(vm);
        }
    }
}
