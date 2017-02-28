using System;
using CMS.Repository;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using System.Collections.Generic;
using System.Linq;

namespace CMS.RepositoryTests
{
    [Binding]
    [Scope(Feature = "CategoryRepositoryTests")]
    public class CategoryRepositoryTestsSteps
    {
        public ICategoryRepository _CategoryRepository;
        public CMSEntities _CmsEntitiesTest;

        [BeforeScenario]
        public void BeforeScenario()
        {
            _CategoryRepository = new CategoryRepository();
            _CmsEntitiesTest = new CMSEntities();
            _CmsEntitiesTest.Categories.RemoveRange(_CmsEntitiesTest.Categories);
            _CmsEntitiesTest.SaveChanges();
        }

        [AfterScenario()]
        public void AfterScenario()
        {
            _CmsEntitiesTest.Categories.RemoveRange(_CmsEntitiesTest.Categories);
            _CmsEntitiesTest.SaveChanges();
        }

        [Given(@"新增測試資料")]
        public void 新增測試資料(Table table)
        {
            var categories = table.CreateSet<Category>();
            _CmsEntitiesTest.Categories.AddRange(categories);
            _CmsEntitiesTest.SaveChanges();
        }


        [Given(@"要新增的資料")]
        public void 要新增的資料(Table table)
        {
            var categories = table.CreateSet<Category>();
            ScenarioContext.Current.Set(categories.FirstOrDefault(), "category");
        }

        [Given(@"要修改的資料")]
        public void 要修改的資料(Table table)
        {
            var categories = table.CreateSet<Category>();
            ScenarioContext.Current.Set(categories.FirstOrDefault(), "category");
        }
        

        [Given(@"預期回傳資料")]
        public void Given預期回傳資料(Table table)
        {
            //var expected = table.CreateSet<Class>();
            ScenarioContext.Current.Set(table, "expected");
        }

        [When(@"透過Add方法新增一筆資料到Category裡面")]
        public void When透過Add方法新增一筆資料到Category裡面()
        {
            //bool result = false;
            var category = ScenarioContext.Current.Get<Category>("category");
            _CategoryRepository.Add(category);
            var act = _CmsEntitiesTest.Categories.AsNoTracking();
            ScenarioContext.Current.Set(act, "act");
        }

        [When(@"透過Udate方法修改資料")]
        public void When透過Udate方法修改資料()
        {
            var CategoryID = _CmsEntitiesTest.Categories.FirstOrDefault().CategoryID;
            var category = ScenarioContext.Current.Get<Category>("category");
            _CategoryRepository.Update(CategoryID, category);
            var act = _CmsEntitiesTest.Categories.AsNoTracking();
            ScenarioContext.Current.Set(act, "act");
        }

        //[When(@"透過GetByCategoryID方法查詢第一筆資料")]
        //public void When透過GetByCategoryID方法查詢第一筆資料()
        //{
        //    var CategoryID = _CmsEntitiesTest.Categories.FirstOrDefault().CategoryID;
        //    var category = _CategoryRepository.GetByCategoryID(CategoryID);
        //    var act = new List<Category>();
        //    act.Add(category);
        //    ScenarioContext.Current.Set(act, "act");
        //}

        [When(@"透過GetByCategoryID方法查詢第 (.*) 筆資料")]
        public void When透過GetByCategoryID方法查詢第筆資料(int countNumber)
        {
            var CategoryID = _CmsEntitiesTest.Categories.OrderBy(x=>x.CategoryID).Skip(countNumber-1).Take(1)
                .FirstOrDefault().CategoryID;
            var category = _CategoryRepository.GetByCategoryID(CategoryID);
            var act = new List<Category>();
            act.Add(category);
            ScenarioContext.Current.Set(act, "act");
        }

        [When(@"透過GetByPage方法取第(.*)筆取(.*)筆")]
        public void When透過GetByPage方法取第筆取筆(int skip, int take)
        {
            var category = _CmsEntitiesTest.Categories.OrderBy(x => x.CategoryID).Skip(skip - 1).Take(take);
            var act = _CategoryRepository.GetByPage(skip, take);
            ScenarioContext.Current.Set(act, "act");
        }

        [When(@"透過Delete方法刪除第一筆資料")]
        public void When透過Delete方法刪除第一筆資料()
        {
            var ModfiyAccount = "test";
            var CategoryID = _CmsEntitiesTest.Categories.FirstOrDefault().CategoryID;
            _CategoryRepository.Delete(CategoryID,ModfiyAccount);
            var act = _CmsEntitiesTest.Categories.AsNoTracking().Where(x=>x.DeleteFalg == 0);
            ScenarioContext.Current.Set(act, "act");
        }

        [Then(@"要跟預期內容一樣")]
        public void Then要跟預期內容一樣()
        {
            var expected = ScenarioContext.Current.Get<Table>("expected");
            var act = ScenarioContext.Current.Get<IEnumerable<Category>>("act");
            expected.CompareToSet(act);
        }

        

    }
}
