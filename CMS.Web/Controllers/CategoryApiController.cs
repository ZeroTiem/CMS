using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AutoMapper;
using CMS.Info;
using CMS.Service;
using CMS.Web.ViewModels;

namespace CMS.Web.Controllers
{
    public class CategoryApiController : ApiController
    {
        private ICategoryService _categoryService;

        public CategoryApiController()
        {
            _categoryService = new CategoryService();
        }

        // GET api/<controller>
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public bool Put(int CategoryID, CategoryUpdateViewModel CategoryUpdateViewModel)
        {

            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<CategoryUpdateViewModel, CategoryInfo>();
            });
            var categoryInfo = Mapper.Map<CategoryInfo>(CategoryUpdateViewModel);

            var modfiyAccount = User.Identity.Name;
            categoryInfo.ModfiyAccount = modfiyAccount;

            return _categoryService.Update(CategoryID, categoryInfo);
        }

        // DELETE api/<controller>/5
        public bool Delete(int CategoryID)
        {
            var modfiyAccount = User.Identity.Name;
            return _categoryService.Delete(CategoryID, modfiyAccount);

        }
    }
}