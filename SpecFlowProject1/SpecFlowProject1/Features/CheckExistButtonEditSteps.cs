using System;
using TechTalk.SpecFlow;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SpecFlowProject1.Features
{
    [Binding]
    public class CheckExistButtonEditSteps
    {
        private IWebDriver driver;

        [Given(@"Find element on page for show and click")]
        public void GivenFindElementOnPageForShowAndClick()
        {
            driver = new ChromeDriver();
            driver.Url = "https://localhost:44377/Goods";
            driver.FindElement(By.CssSelector("body > div > main > table > tbody > tr:nth-child(1) > td:nth-child(4) > a:nth-child(2)")).Click();
        }

        [Then(@"Сheck show is successful")]
        public void ThenСheckShowIsSuccessful()
        {
        }
    }
}
