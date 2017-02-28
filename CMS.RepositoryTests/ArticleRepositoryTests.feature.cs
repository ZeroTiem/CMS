﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.1.0.0
//      SpecFlow Generator Version:2.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace CMS.RepositoryTests
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.1.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClassAttribute()]
    public partial class ArticleRepositoryTestsFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "ArticleRepositoryTests.feature"
#line hidden
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassInitializeAttribute()]
        public static void FeatureSetup(Microsoft.VisualStudio.TestTools.UnitTesting.TestContext testContext)
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner(null, 0);
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "ArticleRepositoryTests", "\tIn order to 是否對資料庫正常動作\r\n\tAs a 專業的工程師\r\n\tI want to be 驗證資料庫資料是否跟我預期的一樣", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassCleanupAttribute()]
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestInitializeAttribute()]
        public virtual void TestInitialize()
        {
            if (((testRunner.FeatureContext != null) 
                        && (testRunner.FeatureContext.FeatureInfo.Title != "ArticleRepositoryTests")))
            {
                CMS.RepositoryTests.ArticleRepositoryTestsFeature.FeatureSetup(null);
            }
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCleanupAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Article新增一筆")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "ArticleRepositoryTests")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("mytag")]
        public virtual void Article新增一筆()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Article新增一筆", new string[] {
                        "mytag"});
#line 7
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "CategoryID",
                        "Tags",
                        "Title",
                        "ImgUrl",
                        "Content",
                        "CreateAccount",
                        "ModfiyAccount",
                        "PublishStatus"});
            table1.AddRow(new string[] {
                        "1",
                        "tag1",
                        "name",
                        "\"test.jpg\"",
                        "test",
                        "test",
                        "test",
                        "1"});
#line 8
 testRunner.Given("要新增的資料", ((string)(null)), table1, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "CategoryID",
                        "Tags",
                        "Title",
                        "ImgUrl",
                        "Content",
                        "CreateAccount",
                        "ModfiyAccount",
                        "PublishStatus"});
            table2.AddRow(new string[] {
                        "1",
                        "tag1",
                        "name",
                        "\"test.jpg\"",
                        "test",
                        "test",
                        "test",
                        "1"});
#line 11
 testRunner.And("預期回傳資料", ((string)(null)), table2, "And ");
#line 14
 testRunner.When("透過Add方法新增一筆資料到Article裡面", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 15
 testRunner.Then("要跟預期內容一樣", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Article修改一筆ByArticleID")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "ArticleRepositoryTests")]
        public virtual void Article修改一筆ByArticleID()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Article修改一筆ByArticleID", ((string[])(null)));
#line 17
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "CategoryID",
                        "Tags",
                        "Title",
                        "ImgUrl",
                        "Content",
                        "CreateAccount",
                        "CreateDateTime",
                        "ModfiyAccount",
                        "ModfiyDateTime",
                        "PublishStatus"});
            table3.AddRow(new string[] {
                        "1",
                        "tag1",
                        "name",
                        "\"test.jpg\"",
                        "test",
                        "test",
                        "2017-02-28",
                        "test",
                        "2017-02-28",
                        "1"});
#line 18
 testRunner.Given("新增測試資料", ((string)(null)), table3, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "CategoryID",
                        "Tags",
                        "Title",
                        "ImgUrl",
                        "Content",
                        "ModfiyAccount",
                        "PublishStatus"});
            table4.AddRow(new string[] {
                        "2",
                        "tag2",
                        "name2",
                        "\"test2.jpg\"",
                        "test2",
                        "test2",
                        "2"});
#line 21
 testRunner.Given("要修改的資料", ((string)(null)), table4, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "CategoryID",
                        "Tags",
                        "Title",
                        "ImgUrl",
                        "Content",
                        "ModfiyAccount",
                        "PublishStatus"});
            table5.AddRow(new string[] {
                        "2",
                        "tag2",
                        "name2",
                        "\"test2.jpg\"",
                        "test2",
                        "test2",
                        "2"});
#line 24
 testRunner.And("預期回傳資料", ((string)(null)), table5, "And ");
#line 27
 testRunner.When("透過Udate方法修改資料", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 28
 testRunner.Then("要跟預期內容一樣", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Article查詢一筆ByArticleID")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "ArticleRepositoryTests")]
        public virtual void Article查詢一筆ByArticleID()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Article查詢一筆ByArticleID", ((string[])(null)));
#line 30
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "ArticleName",
                        "Kind",
                        "publishStatus",
                        "CreateAccount",
                        "CreateDateTime",
                        "ModfiyAccount",
                        "ModfiyDateTime"});
            table6.AddRow(new string[] {
                        "1",
                        "1",
                        "1",
                        "test",
                        "2017-02-27",
                        "test",
                        "2017-02-27"});
            table6.AddRow(new string[] {
                        "2",
                        "2",
                        "2",
                        "test2",
                        "2017-02-27",
                        "test2",
                        "2017-02-27"});
#line 31
 testRunner.Given("新增測試資料", ((string)(null)), table6, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "ArticleName",
                        "Kind",
                        "publishStatus",
                        "CreateAccount",
                        "ModfiyAccount"});
            table7.AddRow(new string[] {
                        "2",
                        "2",
                        "2",
                        "test2",
                        "test2"});
#line 35
 testRunner.And("預期回傳資料", ((string)(null)), table7, "And ");
#line 38
 testRunner.When("透過GetByArticleID方法查詢第 2 筆資料", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 39
 testRunner.Then("要跟預期內容一樣", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Article刪除一筆ByArticleID")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "ArticleRepositoryTests")]
        public virtual void Article刪除一筆ByArticleID()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Article刪除一筆ByArticleID", ((string[])(null)));
#line 41
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                        "ArticleName",
                        "Kind",
                        "publishStatus",
                        "CreateAccount",
                        "CreateDateTime",
                        "ModfiyAccount",
                        "ModfiyDateTime"});
            table8.AddRow(new string[] {
                        "1",
                        "1",
                        "1",
                        "test",
                        "2017-02-27",
                        "test",
                        "2017-02-27"});
            table8.AddRow(new string[] {
                        "2",
                        "2",
                        "2",
                        "test2",
                        "2017-02-27",
                        "test2",
                        "2017-02-27"});
#line 42
 testRunner.Given("新增測試資料", ((string)(null)), table8, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[] {
                        "ArticleName",
                        "Kind",
                        "publishStatus",
                        "CreateAccount",
                        "ModfiyAccount"});
            table9.AddRow(new string[] {
                        "2",
                        "2",
                        "2",
                        "test2",
                        "test2"});
#line 46
 testRunner.And("預期回傳資料", ((string)(null)), table9, "And ");
#line 49
 testRunner.When("透過Delete方法刪除第一筆資料", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 50
 testRunner.Then("要跟預期內容一樣", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Article查詢分頁")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "ArticleRepositoryTests")]
        public virtual void Article查詢分頁()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Article查詢分頁", ((string[])(null)));
#line 52
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table10 = new TechTalk.SpecFlow.Table(new string[] {
                        "ArticleName",
                        "Kind",
                        "publishStatus",
                        "CreateAccount",
                        "CreateDateTime",
                        "ModfiyAccount",
                        "ModfiyDateTime"});
            table10.AddRow(new string[] {
                        "1",
                        "1",
                        "1",
                        "test1",
                        "2017-02-27",
                        "test1",
                        "2017-02-27"});
            table10.AddRow(new string[] {
                        "2",
                        "2",
                        "2",
                        "test2",
                        "2017-02-27",
                        "test2",
                        "2017-02-27"});
            table10.AddRow(new string[] {
                        "3",
                        "3",
                        "3",
                        "test3",
                        "2017-02-27",
                        "test3",
                        "2017-02-27"});
            table10.AddRow(new string[] {
                        "4",
                        "4",
                        "4",
                        "test4",
                        "2017-02-27",
                        "test4",
                        "2017-02-27"});
            table10.AddRow(new string[] {
                        "5",
                        "5",
                        "5",
                        "test5",
                        "2017-02-27",
                        "test5",
                        "2017-02-27"});
            table10.AddRow(new string[] {
                        "6",
                        "6",
                        "6",
                        "test6",
                        "2017-02-27",
                        "test6",
                        "2017-02-27"});
            table10.AddRow(new string[] {
                        "7",
                        "7",
                        "7",
                        "test7",
                        "2017-02-27",
                        "test7",
                        "2017-02-27"});
            table10.AddRow(new string[] {
                        "8",
                        "8",
                        "8",
                        "test8",
                        "2017-02-27",
                        "test8",
                        "2017-02-27"});
            table10.AddRow(new string[] {
                        "9",
                        "9",
                        "9",
                        "test9",
                        "2017-02-27",
                        "test9",
                        "2017-02-27"});
            table10.AddRow(new string[] {
                        "10",
                        "10",
                        "10",
                        "test10",
                        "2017-02-27",
                        "test10",
                        "2017-02-27"});
#line 53
 testRunner.Given("新增測試資料", ((string)(null)), table10, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table11 = new TechTalk.SpecFlow.Table(new string[] {
                        "ArticleName",
                        "Kind",
                        "publishStatus",
                        "CreateAccount",
                        "ModfiyAccount"});
            table11.AddRow(new string[] {
                        "7",
                        "7",
                        "7",
                        "test7",
                        "test7"});
            table11.AddRow(new string[] {
                        "8",
                        "8",
                        "8",
                        "test8",
                        "test8"});
            table11.AddRow(new string[] {
                        "9",
                        "9",
                        "9",
                        "test9",
                        "test9"});
            table11.AddRow(new string[] {
                        "10",
                        "10",
                        "10",
                        "test10",
                        "test10"});
#line 65
 testRunner.And("預期回傳資料", ((string)(null)), table11, "And ");
#line 71
 testRunner.When("透過GetByPage方法取第7筆取4筆", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 72
 testRunner.Then("要跟預期內容一樣", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
