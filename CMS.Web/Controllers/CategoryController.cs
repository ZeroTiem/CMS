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
    public class CategoryController : Controller
    {
        private ICategoryService _categoryService;

        public CategoryController()
        {
            _categoryService = new CategoryService();
        }

        // GET: Category
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(CategoryAddViewModel categoryAddViewModel)
        {
            if (ModelState.IsValid)
            {
                Mapper.Initialize(cfg =>
                {
                    cfg.CreateMap<CategoryAddViewModel, CategoryInfo>();
                });
                var categoryInfo = Mapper.Map<CategoryInfo>(categoryAddViewModel);

                categoryInfo.CreateAccount = User.Identity.Name;
                categoryInfo.ModfiyAccount = User.Identity.Name;

                _categoryService.Add(categoryInfo);
            }
            return View();
        }
    }
}