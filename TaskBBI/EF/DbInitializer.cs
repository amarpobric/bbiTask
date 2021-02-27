using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskBBI.Models;

namespace TaskBBI.EF
{
    public class DbInitializer
    {
        public static void Execute(dbContext context)
        {
            var place1 = new PlaceOfResidence() { Title = "Sarajevo" };
            var place2 = new PlaceOfResidence() { Title = "Mostar"};
            var place3 = new PlaceOfResidence() { Title = "Tuzla" };
            var place4 = new PlaceOfResidence() { Title = "Srebrenica" };
            var place5 = new PlaceOfResidence() { Title = "Bratunac" };

            context.PlaceOfResidence.Add(place1);
            context.PlaceOfResidence.Add(place2);
            context.PlaceOfResidence.Add(place3);
            context.PlaceOfResidence.Add(place4);
            context.PlaceOfResidence.Add(place5);

            var appPackage1 = new ApplicationPackage() { Title = "Basic", Value = 5 };
            var appPackage2 = new ApplicationPackage() { Title = "Premium", Value = 10 };
            var appPackage3 = new ApplicationPackage() { Title = "Supreme", Value = 15 };

            context.ApplicationPackage.Add(appPackage1);
            context.ApplicationPackage.Add(appPackage2);
            context.ApplicationPackage.Add(appPackage3);

            context.SaveChanges();
                          
        }
    }
}
