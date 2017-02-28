using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.Repository
{
    public interface IArticleRepository
    {
        bool Add(Article article);
        bool Update(int articleId, Article article);
        Article GetByArticleID(int articleId);
        IEnumerable<Article> GetByPage(int skip, int take);
        bool Delete(int articleId, string modfiyAccount);
    }
}
