using System;
using System.Collections.Generic;
using System.Linq;
using TechTalk.SpecFlow;
using NSubstitute;
using CMS.Service;
using CMS.Repository;
using CMS.Info;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow.Assist;


namespace CMS.ServiceTests
{
    [Binding]
    public class ArticleServiceTestsSteps
    {
        private IArticleService _articleService;
        private IArticleRepository mork;

        [BeforeScenario()]
        public void BeforeScenario()
        {
            mork = Substitute.For<IArticleRepository>();
            _articleService = new ArticleService(mork);
        }

        [Given(@"要新增的資料")]
        public void Given要新增的資料(Table table)
        {
            var articleInfo = table.CreateSet<ArticleInfo>();
            ScenarioContext.Current.Set(articleInfo.FirstOrDefault(), "articleInfo");
        }
        
        [Given(@"要修改的資料")]
        public void Given要修改的資料(Table table)
        {
            var articleInfo = table.CreateSet<ArticleInfo>();
            ScenarioContext.Current.Set(articleInfo.FirstOrDefault(), "articleInfo");
        }
        
        [Given(@"ArticleID 是 (.*)")]
        public void GivenArticleID是(int ArticleID)
        {
            ScenarioContext.Current.Set(ArticleID, "ArticleID");
        }
        
        [Given(@"預期回傳")]
        public void Given預期回傳(Table table)
        {
            ScenarioContext.Current.Set(table, "expected");
        }
        
        [When(@"使用Add方法新增")]
        public void When使用Add方法新增()
        {
            mork.Add(Arg.Any<Article>()).Returns(true);
            var articleInfo = ScenarioContext.Current.Get<ArticleInfo>("articleInfo");

            //act
            bool act = _articleService.Add(articleInfo);

            ScenarioContext.Current.Set(act, "act");
        }
        
        [When(@"使用Update方法修改")]
        public void When使用Update方法修改()
        {
            var articleId = ScenarioContext.Current.Get<int>("ArticleID"); 
            mork.Update(Arg.Is(1),Arg.Any<Article>()).Returns(true);
            var articleInfo = ScenarioContext.Current.Get<ArticleInfo>("articleInfo");

            //act
            bool act = _articleService.Update(articleId,articleInfo);

            ScenarioContext.Current.Set(act, "act");
        }
        
        [When(@"使用GetByArticleID方法")]
        public void When使用GetByArticleID方法()
        {
            var articleId = ScenarioContext.Current.Get<int>("ArticleID");
            var expected = ScenarioContext.Current.Get<Table>("expected");
            var article = expected.CreateSet<Article>().FirstOrDefault();
            mork.GetByArticleID(Arg.Is(articleId)).Returns(article);

            //act
            ArticleInfo articleInfo = _articleService.GetByArticleID(articleId);

            var act = new List<ArticleInfo>();
            act.Add(articleInfo);
            ScenarioContext.Current.Set(act, "act");
        }
        
        [When(@"使用GetByPage方法 從 第 (.*) 筆 取 (.*) 筆")]
        public void When使用GetByPage方法從第筆取筆(int skip, int take)
        {
            var expected = ScenarioContext.Current.Get<Table>("expected");
            var article = expected.CreateSet<Article>();
            mork.GetByPage(Arg.Is(skip), Arg.Is(take)).Returns(article);

            //act
            var act = _articleService.GetPage(1, 4);

            ScenarioContext.Current.Set(act, "act");
        }
        
        [When(@"使用Delete方法")]
        public void When使用Delete方法()
        {
            var modifyAccount = "test";
            var articleId = ScenarioContext.Current.Get<int>("ArticleID");
            mork.Delete(Arg.Is(articleId), Arg.Any<string>()).Returns(true);

            //act
            var act = _articleService.Delete(articleId, modifyAccount);

            ScenarioContext.Current.Set(act, "act");
        }
        
        [Then(@"預期回傳true")]
        public void Then預期回傳True()
        {
            var act = ScenarioContext.Current.Get<bool>("act");
            Assert.IsTrue(act);
        }
        
        [Then(@"要跟預期內容一樣")]
        public void Then要跟預期內容一樣()
        {
            var expected = ScenarioContext.Current.Get<Table>("expected");
            var act = ScenarioContext.Current.Get<IEnumerable<ArticleInfo>>("act");
            expected.CompareToSet(act);
        }
    }
}
