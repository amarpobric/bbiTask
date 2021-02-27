using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TaskBBI.ViewModels
{
    public class ApplicationCreateViewModel
    {
        [Display(Name = "Matični broj")]
        [Required(ErrorMessage = "Obavezan unos")]
        [StringLength(13, ErrorMessage = "JMBG se mora sastojati od 13 brojeva", MinimumLength = 13)]
        [RegularExpression("^[0-9]*$", ErrorMessage = "Unos ne može biti slovo niti znak")]
        public string JMBG { get; set; }
        [Display(Name = "Ime i prezime")]
        [Required(ErrorMessage = "Obavezan unos")]
        [StringLength(100, ErrorMessage = "Određen unos od 5 do 100 karaktera", MinimumLength = 5)]
        public string FullName { get; set; }
        public string Gender { get; set; }
        [Display(Name ="Datum rođenja")]
        [Required(ErrorMessage = "Obavezan odabir datuma")]
        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy}")]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }
        [Display(Name = "Broj telefona")]
        [Required(ErrorMessage = "Obavezan unos")]
        [RegularExpression(@"^\(?([0][6][0-9])\)?[-. ]?([0-9]{3})[-. ]?([0-9]{3})$", ErrorMessage = "Neispravan format (Primjer: 061321123)")]
        public string PhoneNumber { get; set; }
        [Display(Name = "Email")]
        [Required(ErrorMessage = "Obavezan unos")]
        public string Email { get; set; }

        [Display(Name = "Mjesto stanovanja")]
        [Required(ErrorMessage = "Obavezan odabir")]
        public int PlaceOfResidenceId { get; set; }
        public List<SelectListItem> PlacesOfResidence { get; set; }   
        public int ApplicationPackageId { get; set; }
       
    }
}
