using System;
using TechTalk.SpecFlow;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SpecFlowProject1.Features
{
    [Binding]
    public class CheckExistsButtonUpdateSteps
    {
        private IWebDriver driver;

        [Given(@"Find element on page for edit and click")]
        public void GivenFindElementOnPageForEditAndClick()
        {
            driver = new ChromeDriver();
            driver.Url = "https://localhost:44377/Goods";
            driver.FindElement(By.CssSelector("body > div > main > table > tbody > tr:nth-child(1) > td:nth-child(4) > a:nth-child(2)")).Click();

        }

        [Then(@"Сheck update is successful")]
        public void ThenСheckUpdateIsSuccessful()
        {
        }
    }
}
