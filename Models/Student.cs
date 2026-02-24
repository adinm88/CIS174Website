using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace PhoneWebApp.Models
{
    public class Student
    {
        [Required(ErrorMessage = "First name is required.")]
        public string firstName { get; set; }

        [Required(ErrorMessage = "Last name is required.")]
        public string lastName { get; set; }

        [Required(ErrorMessage = "Grade is required.")]
        public int grade { get; set; }
    }
}
