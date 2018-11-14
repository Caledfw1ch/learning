using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]  // Атрибуты, метки. Сделано, чтобы фреймворк догадался, для чего методы.
    public class GroupCreationTests : AuthTestBase
    {
        [Test]
        public void GroupCreationTest()
        {
            // методы
            app.Navigator.GoToGroupsPage();
            app.Groups.InitNewGroupCreation();
            // инициализация тестовых данных
            GroupData group = new GroupData("ololo");
            group.Header = "qwe";
            group.Footer = "qwek";

            app.Navigator.GoToGroupsPage();
            app.Groups.Create(group);
        }

        [Test]
        public void EmptyGroupCreationTest()
        {
            app.Navigator.GoToGroupsPage();
            app.Groups.InitNewGroupCreation();
            GroupData group = new GroupData("");
            group.Header = "";
            group.Footer = "";
            app.Groups
                .FillGroupForm(group)
                .SubmitGroupCreation()
                .ReturnToGroupsPage();
        }
    }

}