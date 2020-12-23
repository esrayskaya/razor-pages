using System;
using TechTalk.SpecFlow;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SpecFlowProject1.Features
{
    [Binding]
    public class CheckExistDataSteps
    {
        private IWebDriver driver;

        [When(@"I check new data")]
        public void WhenICheckNewData()
        {
            driver = new ChromeDriver();
            driver.Url = "https://localhost:44377/Goods";
            string title = driver.FindElement(By.CssSelector("tr:nth-child(6) > td:nth-child(1)")).Text;
            Assert.AreEqual(title, "T-shirt");
            string color = driver.FindElement(By.CssSelector("tr:nth-child(6) > td:nth-child(2)")).Text;
            Assert.AreEqual(color, "Red");
            string price = driver.FindElement(By.CssSelector("tr:nth-child(6) > td:nth-child(3)")).Text;
            Assert.AreEqual(price, "655,00");
        }

        [Then(@"Test is sucssesfull")]
        public void ThenTestIsSucssesfull()
        {
        }
    }
}
