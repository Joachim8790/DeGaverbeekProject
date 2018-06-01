using DeGaverbeekProject.Domain.DataModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace DeGaverbeekProject.Domain
{
    public class Winkelmandlijn:Entity
    {
        public int ProductID { get; set; }
        public int Aantal { get; set; }
        [ForeignKey("Gebruiker")]
        public string GebruikerID { get; set; }
        public virtual Gebruiker Gebruiker { get; set; }
    }
}