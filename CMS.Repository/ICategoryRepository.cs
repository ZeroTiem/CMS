using System.Collections.Generic;
using System.Linq;

namespace CMS.Repository
{
    public interface ICategoryRepository
    {
        bool Add(Category category);
        bool Update(int categoryId, Category category);
        bool Delete(int categoryId);
        Category GetByCategoryID(int categoryID);
        IEnumerable<Category> GetByPage(int skip, int take);
    }
}