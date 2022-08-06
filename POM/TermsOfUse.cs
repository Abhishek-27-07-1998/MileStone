using System;
using System.Collections.Generic;
using System.Text;
using AventStack.ExtentReports;
using MileStone.Hooks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace MileStone.POM
{
    public class TermsOfUse:BaseClass
    {
        public void OpenURL()
        {
            scenario = extentreport.CreateTest("TermsOfuse").Info("Teststarted");
            scenario.Log(Status.Info, "TermsOfUse");
            driver.Navigate().GoToUrl("https://www.dove.com/in/home.html");
        }
        public void ClickOnTermsOfUse()
        {
            driver.FindElement(By.XPath("//a[@title='Terms of use']")).Click();
            scenario.Log(Status.Info, "Click on Terms of Uses");
        }

        public void VerifyText()
        {
            string actual=BaseClass.driver.FindElement(By.XPath("//b[text()='2. Prohibited Uses']")).Text;
            string expected = "2. Prohibited Uses";

            if (actual == expected)
            {
                Console.WriteLine("The section contains Prohibited Uses");
                Console.WriteLine("The Output is: " + actual);
            }

            else
            {
                Console.WriteLine("The Section doesnot contains prohibited uses");
            }
            scenario.Log(Status.Info, "Verify the text prohibited use");
            ((ITakesScreenshot)BaseClass.driver).GetScreenshot().SaveAsFile(@"C:\Users\mindc1may270\source\repos\MileStone\ScreenShots\Termsofuse.png");
        }
    }
}
