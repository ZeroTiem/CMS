using System;
using TechTalk.SpecFlow;

namespace CMS.ServiceTests....CMS.RepositoryTests
{
    [Binding]
    public class ArticleServiceTestsSteps
    {
        [Given(@"要新增的資料")]
        public void Given要新增的資料(Table table)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"要修改的資料")]
        public void Given要修改的資料(Table table)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"CategoryID 是 (.*)")]
        public void GivenCategoryID是(int p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"預期回傳")]
        public void Given預期回傳(Table table)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"使用Add方法新增")]
        public void When使用Add方法新增()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"使用Update方法修改")]
        public void When使用Update方法修改()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"使用GetByCategoryID方法")]
        public void When使用GetByCategoryID方法()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"使用GetByPage方法 從 第 (.*) 筆 取 (.*) 筆")]
        public void When使用GetByPage方法從第筆取筆(int p0, int p1)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"使用Delete方法")]
        public void When使用Delete方法()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"預期回傳true")]
        public void Then預期回傳True()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"要跟預期內容一樣")]
        public void Then要跟預期內容一樣()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
