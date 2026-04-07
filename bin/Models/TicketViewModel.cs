namespace PhoneWebApp.Models
{
    public class TicketViewModel
    {
        public List<Ticket> Tickets { get; set; }

        public string CurrentStatus { get; set; } = "All";
        public int CurrentSprint { get; set; } = 0;
    }
}
