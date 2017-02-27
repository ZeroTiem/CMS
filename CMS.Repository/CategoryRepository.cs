using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace CMS.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        private CMSEntities _cmsEntities;
        private IDateAndTime _dateAndTime;

        public CategoryRepository()
        {
            _cmsEntities = new CMSEntities();
            _dateAndTime = new DateAndTimeTW();
        }

        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="category"></param>
        /// <returns></returns>
        public bool Add(Category category)
        {
            try
            {
                category.CreateDateTime = _dateAndTime.Get();
                category.ModfiyDateTime = _dateAndTime.Get();
                _cmsEntities.Categories.Add(category);
                _cmsEntities.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        /// <summary>
        /// 修改 
        /// </summary>
        /// <param name="categoryId"></param>
        /// <param name="category"></param>
        /// <returns></returns>
        public bool Update(int categoryId, Category category)
        {
            try
            {
                var categoryEntities = _cmsEntities.Categories.Find(categoryId);
                categoryEntities.CategoryName = category.CategoryName;
                categoryEntities.Kind = category.Kind;
                categoryEntities.PublishStatus = category.PublishStatus;
                categoryEntities.ModfiyAccount = category.ModfiyAccount;
                categoryEntities.ModfiyDateTime = _dateAndTime.Get();
                _cmsEntities.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        /// <summary>
        /// 刪除
        /// </summary>
        /// <param name="categoryId"></param>
        /// <returns></returns>
        public bool Delete(int categoryId)
        {
            try
            {
                var categoryEntities = _cmsEntities.Categories.Find(categoryId);
                categoryEntities.DeleteFalg = 1;
                _cmsEntities.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }    
        }

        public Category GetByCategoryID(int categoryID)
        {
            try
            {
                var categoryEntities = _cmsEntities.Categories.Find(categoryID);
                return categoryEntities;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
