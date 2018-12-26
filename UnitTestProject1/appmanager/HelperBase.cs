using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace GeometaTests
{
    public class HelperBase   // Базовый класс хелперов
    {
        protected IWebDriver driver;
        protected ApplicationManager manager;

        public HelperBase(ApplicationManager manager)
        {
            this.manager = manager;
            driver = manager.Driver;
        }

        public void Type(By locator, string text)    // очищает поле, пишет текст
        {
            if (text != null)
            {
                driver.FindElement(locator).Clear();
                driver.FindElement(locator).SendKeys(text);
            }
        }
        public bool IsElementPresent(By by)   // существует ли объект?
        {
            try
            {
                driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)    // эксепшн, если нет объекта
            {
                return false;
            }
        }
    }
}