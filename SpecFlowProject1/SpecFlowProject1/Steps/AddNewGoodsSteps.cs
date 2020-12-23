using System;
using TechTalk.SpecFlow;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SpecFlowProject1.Features
{
    [Binding]
    public class AddNewGoodsSteps
    {
        private IWebDriver driver;

        [Given(@"I open ""(.*)"" pages")]
        public void GivenIOpenPages(string p0)
        {
            driver = new ChromeDriver();
            driver.Url = p0;
        }
        
        [When(@"I Click button ""(.*)""")]
        public void WhenIClickButton(string p0)
        {
            driver.FindElement(By.LinkText("Добавить запись")).Click();
        }
        
        [When(@"Enter informations ""(.*)"" and ""(.*)"" and ""(.*)""")]
        public void WhenEnterInformationsAndAnd(string p0, string p1, string p2)
        {
            driver.FindElement(By.Id("Title")).SendKeys("Dress1");
            driver.FindElement(By.Id("Color")).SendKeys("Black");
            driver.FindElement(By.Id("Price")).SendKeys("1500");
        }
        
        [When(@"Click ""(.*)""")]
        public void WhenClick(string p0)
        {
            driver.FindElement(By.CssSelector(".btn")).Click();
        }
        
        [Then(@"Goods added is succesful")]
        public void ThenGoodsAddedIsSuccesful()
        {
        }
    }
}
