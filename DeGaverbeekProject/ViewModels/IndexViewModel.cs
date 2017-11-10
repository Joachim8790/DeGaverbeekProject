﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DeGaverbeekProject.ViewModels
{
    public class IndexViewModel
    {
        [Display(Name ="Naam en voornaam")]
        public string name { get; set; }
        [Display(Name = "Emailadres")]
        public string emailaddress { get; set; }
        [Display(Name = "Onderwerp")]
        public string subject { get; set; }
        [Display(Name = "Bericht")]
        public string message { get; set; }
    }
}