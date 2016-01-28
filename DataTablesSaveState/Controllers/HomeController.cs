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
        public ActionResult Index(int cNumber, int? selectedRow)
        {
            if (!selectedRow.HasValue)
                throw new ArgumentNullException( nameof(selectedRow) +  " is null. A row must be selected");
            
            var persons = PersonRepository.Persons;

            var person = persons.First( t => t.ID == selectedRow );

            person.Number = person.Number + cNumber;
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