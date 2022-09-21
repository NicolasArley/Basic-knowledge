using System.Collections.Generic;

namespace Business.Models
{
    
    public class Language
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class Name
    {
        public Language language { get; set; }
        public string name { get; set; }
    }

    public class PokemonSpecy
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class Root
    {
        public int id { get; set; }
        public string name { get; set; }
        public List<Name> names { get; set; }
        public List<PokemonSpecy> pokemon_species { get; set; }
    }
}
