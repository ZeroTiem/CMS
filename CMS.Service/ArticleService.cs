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
    public class ArticleService : IArticleService 
    {
        private IArticleRepository _articleRepository;

        public ArticleService()
        {
            _articleRepository = new ArticleRepository();
        }

        public ArticleService(IArticleRepository articleRepository)
        {
            _articleRepository = articleRepository;
        }

        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="ArticleInfo"></param>
        /// <returns></returns>
        public bool Add(ArticleInfo ArticleInfo)
        {
            try
            {
                Mapper.Initialize(cfg =>
                {
                    cfg.CreateMap<ArticleInfo, Article>();
                });

                var mapper = Mapper.Map<Article>(ArticleInfo);

                return _articleRepository.Add(mapper);
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
        /// <param name="articleId"></param>
        /// <param name="modifyAccount"></param>
        /// <returns></returns>
        public bool Delete(int articleId, string modifyAccount)
        {
            try
            {
                return _articleRepository.Delete(articleId, modifyAccount);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        /// <summary>
        /// 查詢ByID
        /// </summary>
        /// <param name="articleId"></param>
        /// <returns></returns>
        public ArticleInfo GetByArticleID(int articleId)
        {
            try
            {
               var article = _articleRepository.GetByArticleID(articleId);
                Mapper.Initialize(cfg =>
                {
                    cfg.CreateMap<Article, ArticleInfo>();
                });

                var mapper = Mapper.Map<ArticleInfo>(article);
                return mapper;
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
        public IEnumerable<ArticleInfo> GetPage(int skip, int take)
        {
            try
            {
                var article = _articleRepository.GetByPage(skip, take);

                Mapper.Initialize(cfg =>
                {
                    cfg.CreateMap<Article, ArticleInfo>();
                });

                var mapper = Mapper.Map<IEnumerable<ArticleInfo>>(article);

                return mapper;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        /// <summary>
        /// 更新ByID
        /// </summary>
        /// <param name="articleId"></param>
        /// <param name="articleInfo"></param>
        /// <returns></returns>
        public bool Update(int articleId, ArticleInfo articleInfo)
        {
            try
            {
                Mapper.Initialize(cfg =>
                {
                    cfg.CreateMap<ArticleInfo, Article>();
                });

                var mapper = Mapper.Map<Article>(articleInfo);
                return _articleRepository.Update(articleId, mapper);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
