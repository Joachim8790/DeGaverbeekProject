using System.Collections.Generic;

namespace DeGaverbeekProject.Domain
{
    public class Indeling: Entity
    {
        public string IndelingNaam { get; set; }
        public virtual ICollection<Categorie> Categorieën { get; set; }
    }
}