using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Testing
    {
        IWebDriver driver;

        [SetUp]
        public void startBrowser()
        {
            driver = new ChromeDriver("D:\\3rdparty\\chrome");
        }

        [Test]
        public void test()
        {
            driver.Url = "http://www.google.co.in";
            driver.Manage().Window.Maximize();
            IWebElement link = driver.FindElement(By.XPath(".//*[@id='rt-header']//div[2]/div/ul/li[2]/a"));
            link.Click(); 
            driver.Close();
        }

        [TearDown]
        public void closeBrowser()
        {
            driver.Close();
        }

    }
}
