using System;
using TechTalk.SpecFlow;
using MileStone.POM;

namespace MileStone.StepDefinition
{
    [Binding]
    public class SpecFlowFeature1Steps
    {
        Search methodcall = new Search();
        [Given(@"Load the URL")]
        public void GivenLoadTheURL()
        {
            methodcall.OpenURL();
        }
        
        [Given(@"Click on search")]
        public void GivenClickOnSearch()
        {
            methodcall.Click();
        }
        
        [When(@"You enter Shampoo")]
        public void WhenYouEnterShampoo()
        {
            methodcall.EnterValue();
        }
        
        [Then(@"the result should display Shampoo")]
        public void ThenTheResultShouldDisplayShampoo()
        {
            methodcall.ClickOnSearchAndVerifyText();
        }
    }
}
