using System;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TSUITest;

namespace HtmlImplementation
{
    [CodedUITest]
    public class Testing
    {
        [TestMethod]
        public void TsiLoginMethod1()
        {
            var browser = BrowserWindow.Launch(new Uri("https://portaltest.titlesource.com/"));
            var proc = browser.Process;
            
            var login = new TsiLoginPage(new TsiHtmlWriteTextBox(BrowserWindow.FromProcess(proc), "ctl00_contentPlaceHolder_txtUserName"),
                new TsiHtmlWriteTextBox(BrowserWindow.FromProcess(proc), "ctl00_contentPlaceHolder_txtPassword"),
                new TsiHtmlLink(BrowserWindow.FromProcess(proc), "ctl00_contentPlaceHolder_lbtnLogin"));
            login.Run("irenevendor3", "Vendor123");

            var switchVendor = new TsiSwitchVendor(new TsiHtmlLink(BrowserWindow.FromProcess(proc), "ctl00_Menus1_hlnkSwitchVendor"),
                new TsiHtmlWriteTextBox(BrowserWindow.FromProcess(proc), "ctl00$ContentPlaceHolder1$txtVendorNumber"),
                new TsiHtmlButton(BrowserWindow.FromProcess(proc), "ctl00_ContentPlaceHolder1_btnSubmit"),
                new TsiHtmlButton(BrowserWindow.FromProcess(proc), "ctl00_lbtnClose"));
        }

        [TestMethod]
        public void TsiLoginMethod2()
        {
            var browser = BrowserWindow.Launch(new Uri("https://portaltest.titlesource.com/"));
            TestSteps.LogInTest(new TsiHtmlWriteTextBox(browser, "ctl00_contentPlaceHolder_txtUserName"),
                new TsiHtmlWriteTextBox(browser, "ctl00_contentPlaceHolder_txtPassword"),
                new TsiHtmlLink(browser, "ctl00_contentPlaceHolder_lbtnLogin"),
                "irenevendor3",
                "Vendor123");


        }
    }

    public static class TestSteps
    {
        public static void LogInTest(ITextSettable usernameTextBox, ITextSettable passwordTextBox, ILink submitButton, string username, string password)
        {
            usernameTextBox.Value = username;
            passwordTextBox.Value = password;
            submitButton.Click();
        }
    }

    public class TsiHtmlHoverTooltip
    {
        private ITextGettable Tooltip;
        private IHover HoverOn;
    }
}
