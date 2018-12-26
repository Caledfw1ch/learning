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
    public class NavigationHelper : HelperBase    // Хелпер навигации
    {
        public string baseURL;

        public NavigationHelper(ApplicationManager manager, string baseURL)
            : base(manager)
        {
            this.baseURL = baseURL;
        }
        // this - ссылка на текущий объект, в текущий объект его поля помещает значение переданное в качестве параметра (без этого это будет локальная переменная)
        public void GoToHomePage()
        {
            if (driver.Url == baseURL + "/addressbook/")
            {
                return;
            }
            driver.Navigate().GoToUrl(baseURL + "/addressbook/");
        }

        public void GoToGroupsPage()
        {
            if (driver.Url == baseURL + "/addressbook/group.php"
                && IsElementPresent(By.Name("new")))
            {
                return;
            }
            driver.FindElement(By.LinkText("groups")).Click();
        }
    }
}
