
namespace PhoneWebApp.Models
{
    public class TicketRepository : ITicketRepository
    {
        private readonly TicketDbContext _context;

        public TicketRepository(TicketDbContext context)
        {
            _context = context;
        }

        public List<Ticket> GetAll()
        {
            return _context.Tickets.ToList();
        }

        public List<Ticket> GetByStatus(string status)
        {
            return _context.Tickets
                .Where(t => t.Status == status)
                .ToList();
        }
    }
}
