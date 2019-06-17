using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Stanford.NLP.NER.CSharp.Services;

namespace SS.Annotator.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            var service = new NamedEntityRecognitionService();
            var result = service.GetPlacesIndexes("John is in New York. He wants to go to Turkey.");

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}