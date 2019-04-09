// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:3.0.0.0
//      SpecFlow Generator Version:3.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Vermaat.Crm.Specflow.Sample
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.0.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [TechTalk.SpecRun.FeatureAttribute("AccountTests", Description="\tSome tests involving the account entity", SourceFile="AccountTests.feature", SourceLine=0)]
    public partial class AccountTestsFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "AccountTests.feature"
#line hidden
        
        [TechTalk.SpecRun.FeatureInitialize()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "AccountTests", "\tSome tests involving the account entity", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [TechTalk.SpecRun.FeatureCleanup()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void TestInitialize()
        {
        }
        
        [TechTalk.SpecRun.ScenarioCleanup()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Create a new Account", new string[] {
                "API",
                "Chrome",
                "Cleanup"}, SourceLine=4)]
        public virtual void CreateANewAccount()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Create a new Account", null, new string[] {
                        "API",
                        "Chrome",
                        "Cleanup"});
#line 5
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Property",
                        "Value"});
            table1.AddRow(new string[] {
                        "Account Name",
                        "DynamicHands"});
            table1.AddRow(new string[] {
                        "Main Phone",
                        "0612345678"});
            table1.AddRow(new string[] {
                        "Website",
                        "https://dynamichands.nl"});
            table1.AddRow(new string[] {
                        "Industry",
                        "Consulting"});
#line 6
testRunner.When("an account named TestAccount is created with the following values", ((string)(null)), table1, "When ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Property",
                        "Value"});
            table2.AddRow(new string[] {
                        "Account Name",
                        "DynamicHands"});
            table2.AddRow(new string[] {
                        "Main Phone",
                        "0612345678"});
            table2.AddRow(new string[] {
                        "Website",
                        "https://dynamichands.nl"});
            table2.AddRow(new string[] {
                        "Industry",
                        "Consulting"});
#line 12
testRunner.Then("TestAccount has the following values", ((string)(null)), table2, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Update an existing Account", new string[] {
                "API",
                "Chrome",
                "Cleanup"}, SourceLine=19)]
        public virtual void UpdateAnExistingAccount()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Update an existing Account", null, new string[] {
                        "API",
                        "Chrome",
                        "Cleanup"});
#line 20
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "Property",
                        "Value"});
            table3.AddRow(new string[] {
                        "Account Name",
                        "DynamicHands"});
            table3.AddRow(new string[] {
                        "Main Phone",
                        "0612345678"});
            table3.AddRow(new string[] {
                        "Website",
                        "https://dynamichands.nl"});
            table3.AddRow(new string[] {
                        "Industry",
                        "Consulting"});
#line 21
testRunner.Given("an account named TestAccount with the following values", ((string)(null)), table3, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "Property",
                        "Value"});
            table4.AddRow(new string[] {
                        "Account Name",
                        "DynamicHands B.V."});
            table4.AddRow(new string[] {
                        "Main Phone",
                        "06987654321"});
            table4.AddRow(new string[] {
                        "Fax",
                        "4839432324"});
#line 27
testRunner.When("TestAccount is updated with the following values", ((string)(null)), table4, "When ");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "Property",
                        "Value"});
            table5.AddRow(new string[] {
                        "Account Name",
                        "DynamicHands B.V."});
            table5.AddRow(new string[] {
                        "Main Phone",
                        "06987654321"});
            table5.AddRow(new string[] {
                        "Website",
                        "https://dynamichands.nl"});
            table5.AddRow(new string[] {
                        "Industry",
                        "Consulting"});
#line 32
testRunner.Then("TestAccount has the following values", ((string)(null)), table5, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Check visiblity of form items", new string[] {
                "Chrome",
                "Cleanup"}, SourceLine=40)]
        public virtual void CheckVisiblityOfFormItems()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Check visiblity of form items", null, new string[] {
                        "Chrome",
                        "Cleanup"});
#line 41
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "Property",
                        "Value"});
            table6.AddRow(new string[] {
                        "Account Name",
                        "DynamicHands"});
            table6.AddRow(new string[] {
                        "Main Phone",
                        "0612345678"});
            table6.AddRow(new string[] {
                        "Website",
                        "https://dynamichands.nl"});
            table6.AddRow(new string[] {
                        "Industry",
                        "Consulting"});
#line 42
testRunner.When("an account named TestAccount is created with the following values", ((string)(null)), table6, "When ");
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "Property",
                        "Visible"});
            table7.AddRow(new string[] {
                        "SIC Code",
                        "True"});
            table7.AddRow(new string[] {
                        "Ownership",
                        "False"});
#line 48
testRunner.Then("TestAccount\'s form has the following visbility", ((string)(null)), table7, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.TestRunCleanup()]
        public virtual void TestRunCleanup()
        {
            TechTalk.SpecFlow.TestRunnerManager.GetTestRunner().OnTestRunEnd();
        }
    }
}
#pragma warning restore
#endregion
