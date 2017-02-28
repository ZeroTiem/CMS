using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace CMS.Repository
{
    public class ArticleRepository:IArticleRepository
    {
        private CMSEntities _cmsEntities;
        private IDateAndTime _dateAndTime;

        public ArticleRepository()
        {
            _cmsEntities = new CMSEntities();
            _dateAndTime = new DateAndTimeTW();
        }

        public bool Add(Article article)
        {
            try
            {
                article.CreateDateTime = _dateAndTime.Get();
                article.ModifyDateTime = _dateAndTime.Get();
                _cmsEntities.Articles.Add(article);
                _cmsEntities.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public bool Update(int articleId, Article article)
        {
            try
            {
                var articlesEntities = _cmsEntities.Articles.Find(articleId);
                articlesEntities.CategoryID = article.CategoryID;
                articlesEntities.Title = article.Title;
                articlesEntities.Tags = article.Tags;
                articlesEntities.ImgUrl = article.ImgUrl;
                articlesEntities.Content = article.Content;  
                articlesEntities.StratDateTime = article.StratDateTime;
                articlesEntities.EndDateTime = article.EndDateTime;
                articlesEntities.ModifyAccount = article.ModifyAccount;
                articlesEntities.ModifyDateTime = _dateAndTime.Get();
                articlesEntities.PublishStatus = article.PublishStatus;
                _cmsEntities.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public Article GetByArticleID(int articleId)
        {
            try
            {
                var articlesEntities = _cmsEntities.Articles.Find(articleId);               
                return articlesEntities;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public IEnumerable<Article> GetByPage(int skip, int take)
        {
            try
            {
               return _cmsEntities.Articles.OrderBy(x => x.ArticleID).Skip(skip-1).Take(take);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public bool Delete(int articleId, string modfiyAccount)
        {
            try
            {
                var articleEntities =  _cmsEntities.Articles.Find(articleId);
                articleEntities.DeleteFalg = 1;
                articleEntities.ModifyAccount = modfiyAccount;
                articleEntities.ModifyDateTime = _dateAndTime.Get();
                _cmsEntities.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
