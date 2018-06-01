using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DeGaverbeekProject.Domain
{
    public class Categorie
    {
        [Key]
        public long cat_id { get; set; }
        public string cat_code { get; set; }
        public string cat_naam { get; set; }
        public Nullable<short> cat_seq { get; set; }
        public Nullable<long> cat_type_mag { get; set; }
        public Nullable<System.DateTime> created_on { get; set; }
        public string created_by { get; set; }
        public Nullable<System.DateTime> modified_on { get; set; }
        public string modified_by { get; set; }
        [ForeignKey("Indeling")]
        public int? IndelingID { get; set; }
        public virtual Indeling Indeling { get; set; }
    }
}