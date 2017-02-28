using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using CMS.Info;
using CMS.Repository;

namespace CMS.Service
{
    public class CategoryService: ICategoryService
    {
        private ICategoryRepository _categoryRepository;

        public CategoryService()
        {
            _categoryRepository = new CategoryRepository();
        }

        public CategoryService(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }


        public bool Add(CategoryInfo category)
        {
            try
            {
                Mapper.Initialize(cfg =>
                {
                    cfg.CreateMap<CategoryInfo,Category>();
                });

                var mapper = Mapper.Map<Category>(category);

                return _categoryRepository.Add(mapper);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public bool Update(int categoryId, CategoryInfo category)
        {
            try
            {
                Mapper.Initialize(cfg =>
                {
                    cfg.CreateMap<CategoryInfo, Category>();
                });

                var mapper = Mapper.Map<Category>(category);
                return _categoryRepository.Update(categoryId, mapper);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public CategoryInfo GetByCategoryId(int categoryId)
        {
            try
            {
                var category = _categoryRepository.GetByCategoryID(categoryId);

                Mapper.Initialize(cfg =>
                {
                    cfg.CreateMap<Category,CategoryInfo>();
                });

                var mapper = Mapper.Map<CategoryInfo>(category);

                return mapper;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public IEnumerable<CategoryInfo> GetPage(int skip, int take)
        {
            try
            {
                var categorys = _categoryRepository.GetByPage(skip,take);

                Mapper.Initialize(cfg =>
                {
                    cfg.CreateMap<Category, CategoryInfo>();
                });

                var mapper = Mapper.Map<IEnumerable<CategoryInfo>>(categorys);

                return mapper;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public bool Delete(int categoryId,string ModifyAccount)
        {
            try
            {
                return _categoryRepository.Delete(categoryId, ModifyAccount);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
