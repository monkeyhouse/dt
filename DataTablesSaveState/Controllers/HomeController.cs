using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DataTablesSaveState.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {

            var persons = PersonRepository.Persons;

            return View( persons );
        }

        [HttpPost]
        public ActionResult Index(string command)
        {
           
            var persons = PersonRepository.Persons;
            var person = persons.OrderByDescending(t => t.ID).First();
            person.ID = person.ID - 20;
            person.NumOne = 0;

            ViewBag.RowId = person.ID;

            return View(persons);
        }


        /*         
        on change data, 
        page to row and show it hilighted        
        fade to non-hilight
        */
    }
}