using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CMS.Info;

namespace CMS.Service
{
    public interface ICategoryService
    {
        bool Add(CategoryInfo category);
        bool Update(int categoryId, CategoryInfo category);
        CategoryInfo GetByCategoryId(int categoryId);
        IEnumerable<CategoryInfo> GetPage(int i, int i1);
        bool Delete(int categoryId, string modifyAccount);
    }
}
