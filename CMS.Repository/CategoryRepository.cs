﻿using System;
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
                category.ModifyDateTime = _dateAndTime.Get();
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
                categoryEntities.ModifyAccount = category.ModifyAccount;
                categoryEntities.ModifyDateTime = _dateAndTime.Get();
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
        public bool Delete(int categoryId,string ModifyAccount)
        {
            try
            {
                var categoryEntities = _cmsEntities.Categories.Find(categoryId);
                categoryEntities.ModifyAccount = ModifyAccount;
                categoryEntities.ModifyDateTime = _dateAndTime.Get();
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

        /// <summary>
        /// 搜尋
        /// </summary>
        /// <param name="categoryID"></param>
        /// <returns></returns>
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

        /// <summary>
        /// 分頁
        /// </summary>
        /// <param name="skip"></param>
        /// <param name="take"></param>
        /// <returns></returns>
        public IEnumerable<Category> GetByPage(int skip, int take)
        {
            try
            {
                var categorys = _cmsEntities.Categories.OrderBy(x => x.CategoryID).Skip(skip - 1).Take(take).Where(x => x.DeleteFalg == 0);
                return categorys;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
