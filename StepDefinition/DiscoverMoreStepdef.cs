using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;
using MileStone.POM;

namespace MileStone.StepDefinition
{
    [Binding]
    public class DiscoverMoreStepdef
    {
        Discovermore methodcall = new Discovermore();
        [Given(@"Open the URL")]
        public void GivenOpenTheURL()
        {
            methodcall.URLOpen();
        }

        [When(@"You click on dicover more")]
        public void WhenYouClickOnDicoverMore()
        {
            methodcall.ClickOnDiscover();
        }

        [Then(@"Verify the text")]
        public void ThenCerifyTheText()
        {
            methodcall.VerifyText();
        }

    }
}
