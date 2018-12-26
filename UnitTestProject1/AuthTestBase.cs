using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace WebAddressbookTests
{
    public class AuthTestBase : TestBase // Аутентификация
    {
        //public AuthTestBase() : base()    Андрей
        //{

        //}

        [SetUp]
        public void SetupLogin() // Логин-пасс
        {
            app = ApplicationManager.GetInstance();
            app.Auth.Login(new AccountData("admin", "secret"));
        }
    }
}
