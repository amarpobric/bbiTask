using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TaskBBI.ViewModels
{
    public class ApplicationCreateReadOnlyViewModel
    {
      
        [Display(Name ="Matični broj")]
        public string JMBG { get; set; }
        [Display(Name = "Ime i prezime")]
        public string FullName { get; set; }
        [Display(Name = "Email")]
        public string Email { get; set; }
        [Display(Name = "Spol")]
        public string Gender { get; set; }
        [Display(Name = "Broj telefona")]
        public string PhoneNumber { get; set; }
        [Display(Name = "Vrsta paketa")]
        public string ApplicationPackage { get; set; }
        [Display(Name = "Mjesto stanovanja")]
        public string PlaceOfResidence { get; set; }
        [Display(Name = "Datum rođenja")]
      
        public DateTime DateOfBirth { get; set; }
        public int ApplicationPackageId { get; set; }
        public int PlaceOfResidenceId { get; set; }
        [Display(Name = "Iznos popusta")]
        public int DiscountPercentage { get; set; }
        [Display(Name ="Cijena sa popustom")]
        public double DiscountedPrice { get; set; }
    }
}
