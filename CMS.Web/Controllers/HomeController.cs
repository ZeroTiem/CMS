using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CMS.Service;
using CMS.Info;

namespace CMS.Web.Controllers
{
    public class HomeController : Controller
    {
        private FileService _fileService;

        public HomeController()
        {
            _fileService = new FileService();
        }

        public ActionResult Index()
        {

            var datetimeTW = DateTime.UtcNow.AddHours(8);

            _fileService.Add(new FileInfo()
            {
                KindID = 123,
                Category = "123",
                Title = "123",
                FileUrl = "1234",
                CreateAccount = "dadsad",
                ModifyAccount = "fdsfsdfs",
                StratDateTime = datetimeTW,
                EndDateTime = datetimeTW.AddHours(8),
                Status = 1,
            });


            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}