namespace PhoneWebApp.Models
{
    public class OlympicFilterViewModel
    {
        public string Game { get; set; }
        public string Category { get; set; }

        public List<OlympicCountry> Countries { get; set; }
    }
}