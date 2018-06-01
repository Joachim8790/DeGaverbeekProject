using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace DeGaverbeekProject.Domain
{
    public class Bestelling:Entity
    {
        [ForeignKey("Gebruiker")]
        public string GebruikersID { get; set; }
        public Gebruiker Gebruiker { get; set; }

        public double TotaalBedrag { get; set; }
        public virtual ICollection<Bestellijn> Bestellijnen { get; set; }
    }
}