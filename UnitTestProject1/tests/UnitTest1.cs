using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
namespace UnitTestProject1.tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            IWebDriver driver = null;

            int attempt = 0;

            do
            {
                System.Threading.Thread.Sleep(1000);
                attempt++;
            } while (driver.FindElements(By.Id("Test")).Count == 0 && attempt < 60);
        }
    }
}
