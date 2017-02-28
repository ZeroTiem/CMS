using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CMS.Info;

namespace CMS.Service
{
    public interface IArticleService
    {
        bool Add(ArticleInfo ArticleInfo);
        bool Update(int articleId, ArticleInfo articleInfo);
        ArticleInfo GetByArticleID(int articleId);
        IEnumerable<ArticleInfo> GetPage(int skip, int take);
        bool Delete(int articleId, string modifyAccount);
    }
}
