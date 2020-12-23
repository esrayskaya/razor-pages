using System;
using TechTalk.SpecFlow;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SpecFlowProject1.Features
{
    [Binding]
    public class CheckExistsHomeSteps
    {
        private IWebDriver driver;

        [Given(@"Check exist home")]
        public void GivenCheckExistHome()
        {
            driver = new ChromeDriver();
            driver.Url = "https://localhost:44377";
            string title = driver.FindElement(By.CssSelector("h1")).Text;
            Assert.AreEqual(title, "Каталог одежды");
        }
    }
}
