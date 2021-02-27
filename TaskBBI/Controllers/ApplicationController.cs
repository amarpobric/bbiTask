using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TaskBBI.EF;
using TaskBBI.ViewModels;
using TaskBBI.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Net.Mail;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace TaskBBI.Controllers
{
    public class ApplicationController : Controller
    {
        private dbContext _db;
        public ApplicationController(dbContext context)
        {
            _db = context;
        }
       
        public IActionResult Index()
        {
            ApplicationIndexViewModel model = new ApplicationIndexViewModel();
            model.ApplicationPackages = _db.ApplicationPackage.Select(x => new SelectListItem
            {
                Text = x.Title + " " + x.Value.ToString() + " KM",
                Value = x.Id.ToString()
            }).ToList();

            return View(model);
        }
        public IActionResult Create(ApplicationIndexViewModel residence)
        {
            ApplicationCreateViewModel model = new ApplicationCreateViewModel();
            model.DateOfBirth = DateTime.Now;
            //model.ApplicationPackages = _db.ApplicationPackage.Select(x => new SelectListItem
            //{
            //    Text = x.Title + " " + x.Value.ToString() + " KM",
            //    Value = x.Id.ToString()
            //}).ToList();
            model.ApplicationPackageId = residence.ApplicationPackageId;
            model.PlacesOfResidence = _db.PlaceOfResidence.Select(x => new SelectListItem
            {
                Text = x.Title,
                Value = x.Id.ToString()
            }).ToList();

            return View(model);
        }
        public IActionResult CreateReadOnly(ApplicationCreateViewModel model)
        {
            var appPackage = _db.ApplicationPackage.Where(x => x.Id == model.ApplicationPackageId).FirstOrDefault();
            var appPackageTitle = appPackage.Title + " " + appPackage.Value + " KM";
            var placeOfResTitle = _db.PlaceOfResidence.Where(x => x.Id == model.PlaceOfResidenceId).FirstOrDefault().Title;

            ApplicationCreateReadOnlyViewModel readOnly = new ApplicationCreateReadOnlyViewModel();
            readOnly.FullName = model.FullName;
            readOnly.JMBG = model.JMBG;
            readOnly.Gender = model.Gender;
            readOnly.DateOfBirth = model.DateOfBirth;
            readOnly.PhoneNumber = model.PhoneNumber;
            readOnly.Email = model.Email;
            readOnly.ApplicationPackage = appPackageTitle;
            readOnly.PlaceOfResidence = placeOfResTitle;
            readOnly.PlaceOfResidenceId = model.PlaceOfResidenceId;
            readOnly.ApplicationPackageId = model.ApplicationPackageId;

            if(placeOfResTitle == "Srebrenica" || placeOfResTitle == "Bratunac")
            {
                readOnly.DiscountPercentage = 30;               
            }
            if((DateTime.Now.Year - readOnly.DateOfBirth.Year)>17 && (DateTime.Now.Year - readOnly.DateOfBirth.Year) < 26)
            {
                readOnly.DiscountPercentage += 30;
            }
            if (readOnly.DiscountPercentage > 0)
            {
                readOnly.DiscountedPrice = appPackage.Value - ((appPackage.Value * readOnly.DiscountPercentage) / 100);
            }
            return View(readOnly);
        }
        public IActionResult EmailReview (int Id)
        {
            var app = _db.Application.Include(x => x.ApplicationPackage).Include(x => x.PlaceOfResidence).Where(x => x.Id == Id).FirstOrDefault();
            ApplicationCreateReadOnlyViewModel readOnly = new ApplicationCreateReadOnlyViewModel();
            readOnly.FullName = app.FullName;
            readOnly.JMBG = app.JMBG;
            readOnly.Gender = app.Gender;
            readOnly.DateOfBirth = app.DateOfBirth;
            readOnly.PhoneNumber = app.PhoneNumber;
            readOnly.Email = app.Email;
            readOnly.DiscountedPrice = app.DiscountedPrice;
            readOnly.ApplicationPackage = app.ApplicationPackage.Title + " " + app.ApplicationPackage.Value + " KM";
            readOnly.PlaceOfResidence = app.PlaceOfResidence.Title;
            return View(readOnly);
        }
        [HttpPost]
        public IActionResult CreateReadOnly(ApplicationCreateReadOnlyViewModel model)
        {
            if (ModelState.IsValid)
            {
                Application newApp = new Application()
                {
                    JMBG = model.JMBG,
                    FullName = model.FullName,
                    DateOfBirth = model.DateOfBirth,
                    Gender = model.Gender,
                    PhoneNumber = model.PhoneNumber,
                    PlaceOfResidenceId = model.PlaceOfResidenceId,
                    ApplicationPackageId = model.ApplicationPackageId,
                    Email = model.Email,
                    DiscountedPrice = model.DiscountedPrice
                };

                _db.Application.Add(newApp);
                _db.SaveChanges();

                var appPackage = _db.ApplicationPackage.Where(x => x.Id == newApp.ApplicationPackageId).FirstOrDefault();
                var appPackageTitle = appPackage.Title + " " + appPackage.Value + " KM";
                var placeOfResTitle = _db.PlaceOfResidence.Where(x => x.Id == newApp.PlaceOfResidenceId).FirstOrDefault().Title;

                MailMessage message = new MailMessage();
                message.From = new MailAddress("testbbi123@outlook.com");
                message.To.Add(newApp.Email);

                message.IsBodyHtml = true;
                message.BodyEncoding = Encoding.UTF8;
                message.Subject = "Nova aplikacija";
               var body = new StringBuilder();
                body.Append("<html><head>Vaša aplikacija je uspjesno zaprimljena.</head><body> Podaci o Vašoj aplikaciji :"
                     + "<br />" + " Matični broj : " + newApp.JMBG 
                     + "<br />" + " Ime i prezime : " + newApp.FullName                    
                     + "<br />" + " Mjesto stanovanja : " + placeOfResTitle                    
                     + "<br />" + " Vrsta izabranog paketa : " + appPackageTitle                   
                     + "<br />" + "Link za detaljni pregled aplikacije : "
                    + "<br />" + "<a href=" + "http://localhost:55134/Application/EmailReview/" + newApp.Id + ">Link :</a></body></html>");
                message.Body = body.ToString();
                SmtpClient client = new SmtpClient();
                client.Host = "smtp.outlook.com";
                client.Credentials = new System.Net.NetworkCredential("testbbi123@outlook.com", "bbiTest123");
                client.Port = 587;
                client.EnableSsl = true;
                client.Send(message);
                return RedirectToAction("Index", "Home");
            }          
            return View(model);
        }
    }
}
