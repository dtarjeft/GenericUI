using System;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TSUITest;

namespace HtmlImplementation
{
    [CodedUITest]
    public class LoginTest
    {
        private ITestApplication App { get; set; }
        [TestInitialize]
        public void Init()
        {
            App = new HtmlTestApplication(BrowserWindow.Launch());
            var successfulNav = App.NavigateToContext("Login");
            if (!successfulNav)
            {
                Assert.Inconclusive("Invalid Context. Aborting Login Test.");
            }
        }

        [TestMethod]
        public void ContextLogin()
        {
            var loginTitle = App.Context.Name;
            App.AttemptLogIn("irenevendor3", "Vendor123");

            Assert.AreNotEqual(loginTitle, this.App.Context.Name);
        }
    }
}
