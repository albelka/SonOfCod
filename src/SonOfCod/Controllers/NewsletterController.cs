using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SonOfCod.Models;
using Microsoft.EntityFrameworkCore;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace SonOfCod.Controllers
{
    public class NewsletterController : Controller
    {
        private readonly ApplicationDbContext _db;

        public NewsletterController(ApplicationDbContext db)
        {
            _db = db;
        }

        //    public NewsletterController()
        //{ }



        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Newsletter newsletter)
        {

            _db.Newsletters.Add(newsletter);
            _db.SaveChanges();
            return RedirectToAction("Index", "Account");
        }
    }

   
}
