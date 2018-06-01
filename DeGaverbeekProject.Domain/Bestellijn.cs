
using System.ComponentModel.DataAnnotations.Schema;

namespace DeGaverbeekProject.Domain
{
    public class Bestellijn:Entity
    {
        [ForeignKey("Bestelling")]
        public int BestellingID { get; set; }
        public virtual Bestelling Bestelling { get; set; }
        public int  ProductID { get; set; }
        public int Aantal { get; set; }
        
    }
}