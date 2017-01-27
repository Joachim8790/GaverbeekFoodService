using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Web;

namespace De_Gaverbeek.ViewModels
{
    public class ContactViewModel
    {
        [Required(ErrorMessage ="Naam is veplicht in te vullen.")]
        public string Naam { get; set; }
        [EmailAddress(ErrorMessage ="Voer een geldig emailadres in.")]
        [Required(ErrorMessage = "Emailadres is verplicht in te vullen.")]
        public string Emailadres { get; set; }
        [Required(ErrorMessage = "Onderwerp is verplicht in te vullen.")]
        public string Onderwerp { get; set; }
        [Required(ErrorMessage = "Bericht is verplicht in te vullen.")]
        [DataType(DataType.MultilineText)]
        public string Bericht { get; set; }
    }
}