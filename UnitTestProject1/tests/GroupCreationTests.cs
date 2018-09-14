using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class GroupCreationTests : TestBase
    {
        [Test]
        public void GroupCreationTest()
        {
            GroupData group = new GroupData("ololo");
            group.Header = "qwe";
            group.Footer = "qwek";
            app.Navigator.GoToGroupsPage();
            app.Groups.Create(group);
            app.Navigator.GoToGroupsPage();
        }

        [Test]
        public void EmptyGroupCreationTest()
        {
            GroupData group = new GroupData("");
            group.Header = "";
            group.Footer = "";
            app.Navigator.GoToGroupsPage();
            app.Groups.Create(group);
            app.Navigator.GoToGroupsPage();
        }
    }

}