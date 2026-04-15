using Microsoft.EntityFrameworkCore;

namespace PhoneWebApp.Models
{
    public class TicketDbContext : DbContext
    {
        public TicketDbContext(DbContextOptions<TicketDbContext> options)
            : base(options)
        {
        }

        public DbSet<Ticket> Tickets { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Ticket>().HasData(
                new Ticket
                {
                    Id = 1,
                    Name = "Create Base Page",
                    Description = "Basic layout",
                    SprintNumber = 1,
                    PointValue = 3,
                    Status = "To Do"
                },
                new Ticket
                {
                    Id = 2,
                    Name = "Add Decoration",
                    Description = "Decoration",
                    SprintNumber = 1,
                    PointValue = 5,
                    Status = "In Progress"
                },
                new Ticket
                {
                    Id = 3,
                    Name = "Testing",
                    Description = "QA checks",
                    SprintNumber = 2,
                    PointValue = 2,
                    Status = "QA"
                },
                new Ticket
                {
                    Id = 4,
                    Name = "Testing",
                    Description = "QA checks",
                    SprintNumber = 55,
                    PointValue = 23,
                    Status = "QA"
                }
            );
        }
    }
}
