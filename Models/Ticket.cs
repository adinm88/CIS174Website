using System.ComponentModel.DataAnnotations;

namespace PhoneWebApp.Models
{
    public class Ticket
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [StringLength(100)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Description is required")]
        public string Description { get; set; }

        [Range(1, 50, ErrorMessage = "Sprint must be between 1–50")]
        public int SprintNumber { get; set; }

        [Range(1, 13, ErrorMessage = "Points must be between 1–13")]
        public int PointValue { get; set; }

        [Required(ErrorMessage = "Status is required")]
        public string Status { get; set; }
    }
}
