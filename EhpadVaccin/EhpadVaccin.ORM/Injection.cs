using System;
namespace EhpadVaccin.ORM
{
    public class Injection
    {
        public int Id { get; set; }
        public Personne personne { get; set; }
        public DateTime dateInjection { get; set; }
        public DateTime dateRappel { get; set; }
        public int numLot { get; set; }
        public Vaccin typeVaccin { get; set; }
        public string marque { get; set; }

    }
}