using System;
using TechTalk.SpecFlow;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SpecFlowProject1.Features
{
    [Binding]
    public class DeleteGoodsSteps
    {
        private IWebDriver driver;

        [Given(@"the first number is (.*)")]
        public void GivenTheFirstNumberIs(int p0)
        {
            driver = new ChromeDriver();
            driver.Url = "https://localhost:44377/Goods";
            driver.FindElement(By.LinkText("Удалить")).Click();
        }
        
        [Given(@"the second number is (.*)")]
        public void GivenTheSecondNumberIs(int p0)
        {
            driver.FindElement(By.CssSelector(".btn")).Click();
        }
        
        [When(@"the two numbers are added")]
        public void WhenTheTwoNumbersAreAdded()
        {
        }
        
        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBe(int p0)
        {
        }
    }
}
