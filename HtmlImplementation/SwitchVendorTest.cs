using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TSUITest;

namespace HtmlImplementation
{
    [CodedUITest]
    public class SwitchVendorTest
    {
        private ITestApplication App { get; set; }

        [TestInitialize]
        public void Init()
        {
            App = new HtmlTestApplication(BrowserWindow.Launch());
            var successfulNav = App.NavigateToContext("Login");
            if (!successfulNav)
            {
                Assert.Inconclusive("Couldn't log in.");
            }
            App.AttemptLogIn("irenevendor3", "Vendor123");
        }

        [TestMethod]
        public void SwitchVendorTo()
        {
            App.AttemptSwitchVendor("50083");

        }
    }
}