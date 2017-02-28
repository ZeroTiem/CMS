﻿using System;
using System.Collections.Generic;
using System.Linq;
using CMS.Repository;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace CMS.RepositoryTests
{
    [Binding]
    public class ArticleRepositoryTestsSteps
    {
        public IArticleRepository _ArticleRepository;
        public CMSEntities _CmsEntitiesTest;

        [BeforeScenario]
        public void BeforeScenario()
        {
             _ArticleRepository = new ArticleRepository();
            _CmsEntitiesTest = new CMSEntities();
            _CmsEntitiesTest.Articles.RemoveRange(_CmsEntitiesTest.Articles);
            _CmsEntitiesTest.SaveChanges();
        }

        [AfterScenario()]
        public void AfterScenario()
        {
            _CmsEntitiesTest.Articles.RemoveRange(_CmsEntitiesTest.Articles);
            _CmsEntitiesTest.SaveChanges();
        }

        [Given(@"要新增的資料")]
        public void Given要新增的資料(Table table)
        {
            var categories = table.CreateSet<Article>();
            ScenarioContext.Current.Set(categories.FirstOrDefault(), "Article");
        }
        
        [Given(@"預期回傳資料")]
        public void Given預期回傳資料(Table table)
        {
            ScenarioContext.Current.Set(table, "expected");
        }
        
        [Given(@"新增測試資料")]
        public void Given新增測試資料(Table table)
        {
            var article = table.CreateSet<Article>();
            _CmsEntitiesTest.Articles.AddRange(article);
            _CmsEntitiesTest.SaveChanges();
        }
        
        [Given(@"要修改的資料")]
        public void Given要修改的資料(Table table)
        {
            var article = table.CreateSet<Article>();
            ScenarioContext.Current.Set(article.FirstOrDefault(), "Article");
        }
        
        [When(@"透過Add方法新增一筆資料到Article裡面")]
        public void When透過Add方法新增一筆資料到Article裡面()
        {
            var article = ScenarioContext.Current.Get<Article>("Article");
            _ArticleRepository.Add(article);
            var act = _CmsEntitiesTest.Articles.AsNoTracking();
            ScenarioContext.Current.Set(act, "act");
        }
        
        [When(@"透過Udate方法修改資料")]
        public void When透過Udate方法修改資料()
        {
            var ArticleID = _CmsEntitiesTest.Articles.FirstOrDefault().ArticleID;
            var article = ScenarioContext.Current.Get<Article>("Article");
            _ArticleRepository.Update(ArticleID, article);
            var act = _CmsEntitiesTest.Articles.AsNoTracking();
            ScenarioContext.Current.Set(act, "act");
        }
        
        [When(@"透過GetByArticleID方法查詢第 (.*) 筆資料")]
        public void When透過GetByArticleID方法查詢第筆資料(int p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"透過Delete方法刪除第一筆資料")]
        public void When透過Delete方法刪除第一筆資料()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"透過GetByPage方法取第(.*)筆取(.*)筆")]
        public void When透過GetByPage方法取第筆取筆(int p0, int p1)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"要跟預期內容一樣")]
        public void Then要跟預期內容一樣()
        {
            var expected = ScenarioContext.Current.Get<Table>("expected");
            var act = ScenarioContext.Current.Get<IEnumerable<Article>>("act");
            expected.CompareToSet(act);
        }
    }
}
