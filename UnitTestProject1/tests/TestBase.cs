﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace GeometaTests
{
    public class TestBase // Базовый тестовый класс
    {
        public ApplicationManager app;

        //public TestBase()                       //  Андрей
        //{
        //    SetupApplicationManager();
        //}

        [SetUp]
        public void SetupApplicationManager()
        {
            app = ApplicationManager.GetInstance();
           app.Auth.Login(new AccountData("Akeller", "Akeller123$"));    // данные
        }
    }
}
