using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskBBI.Models
{
    public class Application
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string JMBG { get; set; }
        public string Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string PhoneNumber{ get; set; }
        public string Email { get; set; }
        public int PlaceOfResidenceId { get; set; }
        public PlaceOfResidence PlaceOfResidence { get; set; }
        public int ApplicationPackageId { get; set; }
        public ApplicationPackage ApplicationPackage { get; set; }
        public double DiscountedPrice { get; set; }
    }
}
