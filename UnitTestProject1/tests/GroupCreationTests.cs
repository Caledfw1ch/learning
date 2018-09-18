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
            app.Navigator.GoToGroupsPage();
            app.Groups.InitNewGroupCreation();
            GroupData group = new GroupData("ololo");
            group.Header = "qwe";
            group.Footer = "qwek";
            app.Groups
                .FillGroupForm(group)
                .SubmitGroupCreation()
                .ReturnToGroupsPage();
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