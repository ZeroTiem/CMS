using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CMS.Web.Controllers
{
    public class ArticleController : Controller
    {
        // GET: Article
        public ActionResult Index(string CategoryID)
        {
            ViewBag["CategoryID"] = CategoryID;
            return View();
        }
    }
}