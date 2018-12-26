using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace GeometaTests
{
    [TestFixture]
    public class Logintests : TestBase
    {
        private IWebDriver driver;
        private StringBuilder verificationErrors;
        private string baseURL;
        private bool acceptNextAlert = true;

        [Test]
        public void LoginTest1()
        {
            driver.Navigate().GoToUrl(
                baseURL +
                "/account/login?returnUrl=%2Fconnect%2Fauthorize%2Fcallback%3Fclient_id%3Dias.js%26redirect_uri%3Dhttps%253A%252F%252Fteam3.gemsdev.ru%252Fcallback.html%26response_type%3Did_token%2520token%26scope%3Dopenid%2520profile%2520api1%26state%3D34c5d01b40a64e41938392ec4ba9088b%26nonce%3D142def93721449ab9d42ab08324e2464");
            driver.FindElement(By.Id("Username")).Clear();
            driver.FindElement(By.Id("Username")).SendKeys("Akeller");
            driver.FindElement(By.Id("Password")).Clear();
            driver.FindElement(By.Id("Password")).SendKeys("Akeller123$");
            driver.FindElement(By.CssSelector("button.btn.btn-default")).Click(); // кнопка Войти
            driver.FindElement(By.Id("button-1012-btnIconEl")).Click();
            driver.FindElement(By.Id("menuitem-1017-textEl")).Click();
        }

        [Test]
        public void loginWithValidCredentials()
        {
            // подготовка тестовой ситуации
            app.Auth.Logout();

            // действие
            AccountData account = new AccountData("Akeller", "Akeller123$");
            app.Auth.Login(account);

            // проверка
            Assert.IsTrue(app.Auth.IsLoggedIn(account));
        }
    }
}