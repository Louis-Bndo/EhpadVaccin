using System;
namespace EhpadVaccin.ORM
{
    public enum Sexe
    {
        Homme,
        Femme
    }

    public enum Role {
        Resident,
        Personnel

    }

    public class Personne
    {
        public int Id { get; set; }
        public string nom { get; set; }
        public string prenom { get; set; }
        public DateTime dateNaissance { get; set; }
        public Sexe sexe { get; set; }
        public Role role { get; set; }


        public Personne()
        {
        }
    }
}