using System;
using System.Collections.Generic;
using System.EnterpriseServices.Internal;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CMS.Info;
using CMS.Service;

namespace CMS.Web.Controllers
{
    public class CategoryController : Controller
    {

        // GET: Category
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Add()
        {
            return View();
        }
    }
}