using System;
using System.Collections.Generic;
using System.Linq;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CMS.Info;
using CMS.Service;
using CMS.Repository;
using NSubstitute;

namespace CMS.ServiceTests
{
    [Binding]
    public class CategoryServiceTestsSteps
    {
        private ICategoryService _categoryService;
        private ICategoryRepository mork;

        [BeforeScenario()]
        public void BeforeScenario()
        {
            mork = Substitute.For<ICategoryRepository>();
            _categoryService = new CategoryService(mork);
        }

        [Given(@"要新增的資料")]
        public void Given要新增的資料(Table table)
        {
            var categorys = table.CreateSet<CategoryInfo>();
            ScenarioContext.Current.Set(categorys.FirstOrDefault(), "category");
        }

        [Given(@"要修改的資料")]
        public void Given要修改的資料(Table table)
        {
            var categorys = table.CreateSet<CategoryInfo>();
            ScenarioContext.Current.Set(categorys.FirstOrDefault(), "category");
        }

        [Given(@"預期回傳")]
        public void Given預期回傳(Table table)
        {
            ScenarioContext.Current.Set(table, "expected");
        }

        [Given(@"CategoryID 是 (.*)")]
        public void GivenByCategoryID是(int CategoryID)
        {
            ScenarioContext.Current.Set(CategoryID, "CategoryID");
        }

        [When(@"使用Update方法修改")]
        public void When使用Update方法修改()
        {
            mork.Update(Arg.Any<int>(),Arg.Any<Category>()).Returns(true);

            var categoryID = ScenarioContext.Current.Get<int>("CategoryID");
            var category = ScenarioContext.Current.Get<CategoryInfo>("category");

            //act
            bool act = _categoryService.Update(categoryID,category);

            ScenarioContext.Current.Set(act, "act");
        }


        [When(@"使用Add方法新增")]
        public void When使用Add方法新增()
        {
            
            mork.Add(Arg.Any<Category>()).Returns(true);
            var category = ScenarioContext.Current.Get<CategoryInfo>("category");

            //act
            bool act = _categoryService.Add(category);

            ScenarioContext.Current.Set(act, "act");
        }

        [When(@"使用GetByCategoryID方法")]
        public void When使用GetByCategoryID方法()
        {
            var expected = ScenarioContext.Current.Get<Table>("expected");
            var category = expected.CreateSet<Category>().FirstOrDefault();
            mork.GetByCategoryID(Arg.Any<int>()).Returns(category);
            var categoryId = ScenarioContext.Current.Get<int>("CategoryID");

            //act
            CategoryInfo categoryInfo = _categoryService.GetByCategory(categoryId);

            var act = new List<CategoryInfo>();
            act.Add(categoryInfo);
            ScenarioContext.Current.Set(act, "act");
        }

        [When(@"使用GetByPage方法 從 第 (.*) 筆 取 (.*) 筆")]
        public void When使用GetByPage方法從第筆取筆(int skip, int take)
        {
            var expected = ScenarioContext.Current.Get<Table>("expected");
            var categorys = expected.CreateSet<Category>();
            mork.GetByPage(Arg.Is(skip),Arg.Is(take)).Returns(categorys);

            //act
            var act = _categoryService.GetPage(1,4);

            ScenarioContext.Current.Set(act, "act");
        }

        [When(@"使用Delete方法")]
        public void When使用Delete方法()
        {
            var categoryId = ScenarioContext.Current.Get<int>("CategoryID");
            mork.Delete(Arg.Any<int>()).Returns(true);

            //act
            var act = _categoryService.Delete(categoryId);

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
            var act = ScenarioContext.Current.Get<IEnumerable<CategoryInfo>>("act");
            expected.CompareToSet(act);
        }

    }
}
