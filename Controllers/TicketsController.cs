using Microsoft.AspNetCore.Mvc;
using PhoneWebApp.Models;
using System.ComponentModel.DataAnnotations;

namespace PhoneWebApp.Controllers
{
    public class TicketsController : Controller
    {
        private readonly ITicketRepository _repo;
        public TicketsController(ITicketRepository repo)
        {
            _repo = repo;
        }
        public IActionResult Index(string status = "All")
        {
            var vm = new TicketViewModel();

            vm.CurrentStatus = status;

            vm.Tickets = status == "All" ? _repo.GetAll() : _repo.GetByStatus(status);

            List<Ticket> validTickets = new List<Ticket>();
            // VALIDATE EACH TICKET
            foreach (var ticket in vm.Tickets)
            {
                var context = new ValidationContext(ticket);
                var results = new List<ValidationResult>();

                bool isValid = Validator.TryValidateObject(ticket, context, results, true);

                if (isValid)
                {
                    validTickets.Add(ticket);
                }
                else
                {
                    foreach (var error in results)
                    {
                        ModelState.AddModelError("",
                            $"Ticket '{ticket.Name}' with ID: {ticket.Id}: {error.ErrorMessage}. Ticket was not displayed");

                    }


                }
               
            }
            vm.Tickets = validTickets;
            return View(vm);
        }
    }
}