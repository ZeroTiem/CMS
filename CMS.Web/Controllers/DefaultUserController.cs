using System;
using System.Collections.Generic;
using System.EnterpriseServices.Internal;
using System.Linq;
using System.Web;
using AutoMapper;
using System.Web.Mvc;
using CMS.Info;
using CMS.Service;
using CMS.Web.ViewModels;

namespace CMS.Web.Controllers
{
    public class DefaultUserController : Controller
    {
        private ICategoryService _categoryService;

        public DefaultUserController()
        {
            _categoryService = new CategoryService();
        }

        // GET: DefaultUser
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Category()
        {
            var categoryInfo = _categoryService.GetPage(1, 100);
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<CategoryInfo, DefaultUserCategoryViewModel>();
            });
            var DefaultUserCategoryViewModel = Mapper.Map<IEnumerable<DefaultUserCategoryViewModel>>(categoryInfo);

            return View(DefaultUserCategoryViewModel);
        }
    }
}