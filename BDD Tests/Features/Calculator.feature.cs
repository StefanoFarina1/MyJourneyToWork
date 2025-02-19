// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (https://www.specflow.org/).
//      SpecFlow Version:3.9.0.0
//      SpecFlow Generator Version:3.9.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace MyJourneyToWorkBDD.Features
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Calculator")]
    public partial class CalculatorFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
#line 1 "Calculator.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features", "Calculator", "    In order to promote environmental awareness\r\n    As a user\r\n    I want to kno" +
                    "w the sustainability impact of my travel choices", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<NUnit.Framework.TestContext>(NUnit.Framework.TestContext.CurrentContext);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Calculate total carbon footprint for diesel mode")]
        public virtual void CalculateTotalCarbonFootprintForDieselMode()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Calculate total carbon footprint for diesel mode", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
            this.ScenarioInitialize(scenarioInfo);

            this.ScenarioStart();
            testRunner.Given("I have chosen 'diesel' as my transport mode", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
            testRunner.And("I set the distance to '20' miles", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.And("I travel '4' days a week", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.When("I calculate the sustainability weighting", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("the result should be '144'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");

            this.ScenarioCleanup();
        }

        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Calculate total carbon footprint for electric bike mode")]
        public virtual void CalculateTotalCarbonFootprintForElectricBikeMode()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Calculate total carbon footprint for electric bike mode", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
            this.ScenarioInitialize(scenarioInfo);

            this.ScenarioStart();
            testRunner.Given("I have chosen 'electricbike' as my transport mode", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
            testRunner.And("I set the distance to '5' miles", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.And("I travel '7' days a week", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.When("I calculate the sustainability weighting", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("the result should be '0.35'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");

            this.ScenarioCleanup();
        }

        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Calculate total carbon footprint for hybrid mode")]
        public virtual void CalculateTotalCarbonFootprintForHybridMode()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Calculate total carbon footprint for hybrid mode", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
            this.ScenarioInitialize(scenarioInfo);

            this.ScenarioStart();
            testRunner.Given("I have chosen 'hybrid' as my transport mode", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
            testRunner.And("I set the distance to '30' miles", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.And("I travel '2' days a week", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.When("I calculate the sustainability weighting", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("the result should be '10.8'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");

            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
