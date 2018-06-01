using DeGaverbeekProject.Domain.DataModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeGaverbeekProject.Domain
{
    public class Gebruiker
    {
        [Key]
        public string GebruikersID { get; set; }
        public int KlantCode { get; set; }
        [Required]
        public string BedrijfsNaam { get; set; }
        [Required]
        public string VoornaamContact { get; set; }
        [Required]
        public string AchternaamContact { get; set; }
        [Required]
        public string Straat { get; set; }
        [Required]
        public string Nummer { get; set; }
        [Required]
        [DataType(DataType.PostalCode)]
        public string Postcode { get; set; }
        [Required]
        public string Stad { get; set; }
        [Required]
        public string Land { get; set; }
        [Required]
        public string Ondernemingsnummer { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [DataType(DataType.PhoneNumber)]
        public String Telefoon { get; set; }
        [DataType(DataType.PhoneNumber)]
        public String GSM { get; set; }
        public String Fax { get; set; }

        public virtual ICollection<Winkelmandlijn> Winkelmandlijnen { get; set; }

    }
}
