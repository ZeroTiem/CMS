using System.Collections.Generic;

namespace CMS.Repository
{
    public interface ICategoryRepository
    {
        bool Add(Category category);
        bool Update(int categoryId, Category category);
        bool Delete(int categoryId);
        Category GetByCategoryID(int categoryID);
    }
}