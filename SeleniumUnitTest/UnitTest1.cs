using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Search_FindResults_ResultPageIsShown()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(5));
            driver.Navigate().GoToUrl("https://en.wikipedia.org/wiki/Main_Page");
            IWebElement searchInput = driver.FindElement(By.Id("searchInput"));

            searchInput.SendKeys("Christiaan Barnard");
            searchInput.SendKeys(Keys.Enter);

            String result = driver.FindElement(By.Id("firstHeading")).Text;
            driver.Close();

            Assert.AreEqual("Christiaan Barnard", result);
            
        }
    }
}
