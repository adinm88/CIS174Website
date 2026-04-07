namespace PhoneWebApp.Models
{
    public class OlympicRepository
    {
        public static List<OlympicCountry> GetCountries()
        {
            return new List<OlympicCountry>() {
                // Winter Olympics - Curling (Indoor)
            new OlympicCountry { Country="Canada", Game="Winter Olympics", Sport="Curling", Category="Indoor", FlagImage="canada.png" },
            new OlympicCountry { Country="Sweden", Game="Winter Olympics", Sport="Curling", Category="Indoor", FlagImage="sweden.png" },
            new OlympicCountry { Country="Great Britain", Game="Winter Olympics", Sport="Curling", Category="Indoor", FlagImage="greatbritain.png" },

            // Winter Olympics - Bobsleigh (Outdoor)
            new OlympicCountry { Country="Jamaica", Game="Winter Olympics", Sport="Bobsleigh", Category="Outdoor", FlagImage="jamaica.png" },
            new OlympicCountry { Country="Italy", Game="Winter Olympics", Sport="Bobsleigh", Category="Outdoor", FlagImage="italy.png" },
            new OlympicCountry { Country="Japan", Game="Winter Olympics", Sport="Bobsleigh", Category="Outdoor", FlagImage="japan.png" },

            // Summer Olympics - Diving (Indoor)
            new OlympicCountry { Country="Germany", Game="Summer Olympics", Sport="Diving", Category="Indoor", FlagImage="germany.png" },
            new OlympicCountry { Country="China", Game="Summer Olympics", Sport="Diving", Category="Indoor", FlagImage="china.png" },
            new OlympicCountry { Country="Mexico", Game="Summer Olympics", Sport="Diving", Category="Indoor", FlagImage="mexico.png" },

            // Summer Olympics - Cycling (Outdoor)
            new OlympicCountry { Country="Brazil", Game="Summer Olympics", Sport="Road Cycling", Category="Outdoor", FlagImage="brazil.png" },
            new OlympicCountry { Country="Netherlands", Game="Summer Olympics", Sport="Cycling", Category="Outdoor", FlagImage="netherlands.png" },
            new OlympicCountry { Country="USA", Game="Summer Olympics", Sport="Road Cycling", Category="Outdoor", FlagImage="usa.png" },

            // Paralympics - Archery (Indoor)
            new OlympicCountry { Country="Thailand", Game="Paralympics", Sport="Archery", Category="Indoor", FlagImage="thailand.png" },
            new OlympicCountry { Country="Uruguay", Game="Paralympics", Sport="Archery", Category="Indoor", FlagImage="uruguay.png" },
            new OlympicCountry { Country="Ukraine", Game="Paralympics", Sport="Archery", Category="Indoor", FlagImage="ukraine.png" },

            // Paralympics - Canoe Sprint (Outdoor)
            new OlympicCountry { Country="Austria", Game="Paralympics", Sport="Canoe Sprint", Category="Outdoor", FlagImage="austria.png" },
            new OlympicCountry { Country="Pakistan", Game="Paralympics", Sport="Canoe Sprint", Category="Outdoor", FlagImage="pakistan.png" },
            new OlympicCountry { Country="Zimbabwe", Game="Paralympics", Sport="Canoe Sprint", Category="Outdoor", FlagImage="zimbabwe.png" },

            // Youth Olympic Games - Breakdancing (Indoor)
            new OlympicCountry { Country="France", Game="Youth Olympic Games", Sport="Breakdancing", Category="Indoor", FlagImage="france.png" },
            new OlympicCountry { Country="Cyprus", Game="Youth Olympic Games", Sport="Breakdancing", Category="Indoor", FlagImage="cyprus.png" },
            new OlympicCountry { Country="Russia", Game="Youth Olympic Games", Sport="Breakdancing", Category="Indoor", FlagImage="russia.png" },

            // Youth Olympic Games - Skateboarding (Outdoor)
            new OlympicCountry { Country="Finland", Game="Youth Olympic Games", Sport="Skateboarding", Category="Outdoor", FlagImage="finland.png" },
            new OlympicCountry { Country="Slovakia", Game="Youth Olympic Games", Sport="Skateboarding", Category="Outdoor", FlagImage="slovakia.png" },
            new OlympicCountry { Country="Portugal", Game="Youth Olympic Games", Sport="Skateboarding", Category="Outdoor", FlagImage="portugal.png" }
            };
        }
       
    }

}
