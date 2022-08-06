using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;
using MileStone.POM;

namespace MileStone.StepDefinition
{
    [Binding]
    public class TermsOfUseStepdefinition
    {
        TermsOfUse methodcall = new TermsOfUse();
        [Given(@"Open the Link")]
        public void GivenOpenTheLink()
        {
            methodcall.OpenURL();
        }

        [When(@"Ypu click on TermsofUse")]
        public void WhenYpuClickOnTermsofUse()
        {
            methodcall.ClickOnTermsOfUse();
        }

        [Then(@"Verify the text ProhibitedUse")]
        public void ThenVerifyTheTextProhibitedUse()
        {
            methodcall.VerifyText();
        }

    }
}
