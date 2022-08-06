using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Model;
using MileStone.Hooks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace MileStone.POM
{
    public class Search:BaseClass
    {
        public void OpenURL()
        {
            
            scenario = extentreport.CreateTest("Search").Info("Teststarted");
            scenario.Log(Status.Info, "Search feature");
            driver.Navigate().GoToUrl("https://www.dove.com/in/home.html");
            driver.Manage().Window.Maximize();    
            
        }
        public void Click()
        {
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//button[text()='OK']")).Click();
            scenario.Log(Status.Info, "CLick on Search");
            driver.FindElement(By.XPath("//button[@class='o-navbar-label js-search-btn']")).Click();
        }

        public void EnterValue()
        {
            Thread.Sleep(3000);
            scenario.Log(Status.Info, "Enter Shampoo in searchbar");
            driver.FindElement(By.XPath("/html/body/div[1]/header/div[2]/div[1]/div/div/div/div/div/div/form/div[2]/div/span/input")).SendKeys("Shampoo");
            driver.FindElement(By.XPath("/html/body/div[1]/header/div[2]/div[1]/div/div/div/div/div/div/form/div[2]/div/button[2]")).Click();
        }


        public void ClickOnSearchAndVerifyText()
        {
            scenario.Log(Status.Info, "Click search and verify the text");
            Thread.Sleep(4000);
            string actual=driver.FindElement(By.XPath("//h2[text()='Baby Shampoo']")).Text;
            if (actual.Contains("Shampoo"))
            {
                Console.WriteLine("The Text contains Shampoo in the first search result and the text is: " + actual);
            }
            ((ITakesScreenshot)BaseClass.driver).GetScreenshot().SaveAsFile(@"C:\Users\mindc1may270\source\repos\MileStone\ScreenShots\Search.png");
        }
    }
}
