using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Charts.DAL;

namespace Charts.Web.Controllers
{
    public class HomeController : Controller
    {
        private Repository _repository;

        public HomeController()
        {
            _repository = new Repository();
        }

        // GET: Home
        public ActionResult Index()
        {
            var transactions = _repository.GetAllTransaction();

            return View(transactions);
        }

        public ActionResult Ajax()
        {
            return View();
        }
    }
}