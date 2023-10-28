using Laboratorium_3___App.Models;
using Microsoft.AspNetCore.Mvc;

namespace Laboratorium_3___App.Controllers
{
    public class ContactController : Controller
    {
        private readonly IContactService contactService;

        public ContactController(IContactService contactService)
        {
            this.contactService = contactService;
        }

        public IActionResult Index()
        {
            return View(contactService.FindAll());
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Contact model)
        {
            contactService.Add(model);
            return RedirectToAction("Index");
        }

        public IActionResult Details(int id)
        {
            return View(contactService.FindById(id));
        }
        //public IActionResult Details() { }
    }
}
