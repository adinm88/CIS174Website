namespace PhoneWebApp.Models
{
    public interface ITicketRepository
    {
        List<Ticket> GetAll();
        List<Ticket> GetByStatus(string status);
    }
}
