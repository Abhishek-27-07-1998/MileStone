using System;
using System.Collections.Generic;
using System.Text;
using AventStack.ExtentReports;
using MileStone.Hooks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace MileStone.POM
{
    public class Discovermore:BaseClass
    {
        public void URLOpen()
        {
            scenario = extentreport.CreateTest("DiscoverMore").Info("Teststarted");
            scenario.Log(Status.Info, "DiscoverMore open");
            driver.Navigate().GoToUrl("https://www.dove.com/in/home.html");
            
        }

        public void ClickOnDiscover()
        {
            driver.FindElement(By.XPath("(//a[@class='o-btn o-btn--secondary'])[1]")).Click();
            scenario.Log(Status.Info, "Click on Discover");
        }

        public void VerifyText()
        {
           string actual= BaseClass.driver.FindElement(By.XPath("(//h2[@class='o-text__heading-2'])[1]")).Text;
            string expected = "The Real Women behind #StopTheBeautyTest";

            if (actual == expected)
            {
                Console.WriteLine("The tesxt is: " + actual);
            }
            else
            {
                Console.WriteLine("The text is not same as expected");
            }
            scenario.Log(Status.Info, "Verify text");
            ((ITakesScreenshot)BaseClass.driver).GetScreenshot().SaveAsFile(@"C:\Users\mindc1may270\source\repos\MileStone\ScreenShots\DiscoverMore.png");
        }
    }
}
