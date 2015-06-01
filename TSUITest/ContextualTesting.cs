using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSUITest
{
    public static class ContextualTesting
    {
        #region Common Test Processes
        public static void AttemptLogIn(this ITestApplication App, string username, string password)
        {
            App.ChangeFreeFormInput("Username", username);
            App.ChangeFreeFormInput("Password", password);
            App.Click("Login");
        }
        public static void AttemptSwitchVendor(this ITestApplication App, string vendorNumber)
        {
            App.ChangeFreeFormInput("VendorEntry", vendorNumber);
            App.Click("Switch");
            App.Click("Close");
        }
        #endregion

        #region Syntactic Extraction
        private static void ChangeFreeFormInput(this ITestApplication App, string name, string value)
        {
            ((IFreeFormInput)App.Context.GetControlByName(name)).Value = value;
        }
        private static void Click(this ITestApplication App, string name)
        {
            ((IClickable) App.Context.GetControlByName(name)).Click();
        }
        #endregion
    }
}
