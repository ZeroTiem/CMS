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
namespace CMS.ServiceTests
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.1.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClassAttribute()]
    public partial class CategoryServiceTestsFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "CategoryServiceTests.feature"
#line hidden
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassInitializeAttribute()]
        public static void FeatureSetup(Microsoft.VisualStudio.TestTools.UnitTesting.TestContext testContext)
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner(null, 0);
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "CategoryServiceTests", "\tIn order to 避免邏輯錯誤\r\n\tAs a 專業的工程師\r\n\tI want to 驗證是否可以正常運行邏輯與預期是否一樣", ProgrammingLanguage.CSharp, ((string[])(null)));
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
                        && (testRunner.FeatureContext.FeatureInfo.Title != "CategoryServiceTests")))
            {
                CMS.ServiceTests.CategoryServiceTestsFeature.FeatureSetup(null);
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
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Category新增邏輯")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "CategoryServiceTests")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("mytag")]
        public virtual void Category新增邏輯()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Category新增邏輯", new string[] {
                        "mytag"});
#line 7
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "CategoryName",
                        "Kind",
                        "publishStatus",
                        "CreateAccount",
                        "ModifyAccount"});
            table1.AddRow(new string[] {
                        "test",
                        "1",
                        "1",
                        "test",
                        "test"});
#line 8
 testRunner.Given("要新增的資料", ((string)(null)), table1, "Given ");
#line 11
 testRunner.When("使用Add方法新增", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 12
 testRunner.Then("預期回傳true", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Category修改ByCategoryID邏輯")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "CategoryServiceTests")]
        public virtual void Category修改ByCategoryID邏輯()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Category修改ByCategoryID邏輯", ((string[])(null)));
#line 14
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "CategoryName",
                        "Kind",
                        "publishStatus",
                        "CreateAccount",
                        "ModifyAccount"});
            table2.AddRow(new string[] {
                        "test",
                        "1",
                        "1",
                        "test",
                        "test"});
#line 15
 testRunner.Given("要修改的資料", ((string)(null)), table2, "Given ");
#line 18
 testRunner.And("CategoryID 是 1", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 19
 testRunner.When("使用Update方法修改", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 20
 testRunner.Then("預期回傳true", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Category查詢ByCategoryID邏輯")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "CategoryServiceTests")]
        public virtual void Category查詢ByCategoryID邏輯()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Category查詢ByCategoryID邏輯", ((string[])(null)));
#line 22
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "CategoryName",
                        "Kind",
                        "publishStatus",
                        "CreateAccount",
                        "CreateDateTime",
                        "ModifyAccount",
                        "ModifyDateTime"});
            table3.AddRow(new string[] {
                        "test",
                        "1",
                        "1",
                        "test",
                        "2017-02-27",
                        "test",
                        "2017-02-27"});
#line 23
 testRunner.Given("預期回傳", ((string)(null)), table3, "Given ");
#line 26
 testRunner.And("CategoryID 是 1", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 27
 testRunner.When("使用GetByCategoryID方法", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 28
 testRunner.Then("要跟預期內容一樣", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Category查詢分頁邏輯")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "CategoryServiceTests")]
        public virtual void Category查詢分頁邏輯()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Category查詢分頁邏輯", ((string[])(null)));
#line 30
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "CategoryName",
                        "Kind",
                        "publishStatus",
                        "CreateAccount",
                        "CreateDateTime",
                        "ModifyAccount",
                        "ModifyDateTime"});
            table4.AddRow(new string[] {
                        "test",
                        "1",
                        "1",
                        "test",
                        "2017-02-27",
                        "test",
                        "2017-02-27"});
            table4.AddRow(new string[] {
                        "test",
                        "2",
                        "2",
                        "test",
                        "2017-02-27",
                        "test",
                        "2017-02-27"});
            table4.AddRow(new string[] {
                        "test",
                        "3",
                        "3",
                        "test",
                        "2017-02-27",
                        "test",
                        "2017-02-27"});
            table4.AddRow(new string[] {
                        "test",
                        "4",
                        "4",
                        "test",
                        "2017-02-27",
                        "test",
                        "2017-02-27"});
#line 31
 testRunner.Given("預期回傳", ((string)(null)), table4, "Given ");
#line 37
 testRunner.When("使用GetByPage方法 從 第 1 筆 取 4 筆", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 38
 testRunner.Then("要跟預期內容一樣", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Category刪除ByCategoryID邏輯")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "CategoryServiceTests")]
        public virtual void Category刪除ByCategoryID邏輯()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Category刪除ByCategoryID邏輯", ((string[])(null)));
#line 40
this.ScenarioSetup(scenarioInfo);
#line 41
 testRunner.Given("CategoryID 是 1", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 42
 testRunner.When("使用Delete方法", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 43
 testRunner.Then("預期回傳true", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
