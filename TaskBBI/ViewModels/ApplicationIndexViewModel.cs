using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TaskBBI.ViewModels
{
    public class ApplicationIndexViewModel
    {
        [Display(Name = "Vrsta paketa")]
        [Required(ErrorMessage = "Obavezan odabir")]
        public int ApplicationPackageId { get; set; }
        public List<SelectListItem> ApplicationPackages { get; set; }
    }
}
