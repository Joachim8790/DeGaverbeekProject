//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DeGaverbeekProject.Domain.DataModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class klanten_adressen
    {
        public int klant_adres_id { get; set; }
        public Nullable<int> klant_id { get; set; }
        public string klant_naam { get; set; }
        public string klant_adres { get; set; }
        public string klant_post { get; set; }
        public string klant_local { get; set; }
        public string klant_land { get; set; }
        public string klant_telefoon { get; set; }
        public string klant_fax { get; set; }
        public string klant_gsm { get; set; }
        public string klant_email { get; set; }
        public Nullable<sbyte> klant_adres_actief { get; set; }
        public Nullable<sbyte> klant_adres_default { get; set; }
        public Nullable<System.DateTime> created_on { get; set; }
        public string created_by { get; set; }
        public Nullable<System.DateTime> modified_on { get; set; }
        public string modified_by { get; set; }
    }
}
