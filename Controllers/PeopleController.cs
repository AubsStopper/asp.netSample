using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SampleSite.Models;

namespace SampleSite.Controllers
{
    public class PeopleController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public ActionResult ListPeople()
        {
            List<PersonModel> people = new List<PersonModel>();

            people.Add(new PersonModel { FirstName = "Sam", LastName = "Samerstein", Age = 39 });
            people.Add(new PersonModel { FirstName = "Timmy", LastName = "Tomcat", Age = 14 });
            people.Add(new PersonModel { FirstName = "Jelly", LastName = "Bean", Age = 45 });

            return View(people);
        }
    }
}