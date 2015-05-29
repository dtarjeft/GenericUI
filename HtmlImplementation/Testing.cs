using System;
using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TSUITest;

namespace HtmlImplementation
{
    [CodedUITest]
    public class Testing
    {
        private ITestApplication app { get; set; }
        [TestInitialize]
        public void Init()
        {
            app = new HtmlTestApplication ( new TsiHtmlContext(BrowserWindow.Launch("http://www.google.com/")));
        }

        [TestMethod]
        public void ContextLogin()
        {
            var successfulNav = app.NavigateToContext("Login");
            if (!successfulNav)
            {
                Assert.Fail("Tried to go somewhere that this app doesn't know how to get to.");
            }

            var usernameControl = (IFreeFormInput) this.app.Context.GetControlByName("Username"); // Actually maybe this could be a generic and you could specify the return type as a type argument?

            usernameControl.Value = "user";

            var passwordControl = (IFreeFormInput) this.app.Context.GetControlByName("Password");
            passwordControl.Value = "password1234";

            var loginButton = (IClickable) this.app.Context.GetControlByName("Login");
            loginButton.Click();

            Assert.AreEqual("WhateverPageComesNext", this.app.Context.Name);
        }
    }

    public class HtmlTestApplication : ITestApplication
    {
        private static BrowserWindow _webPage;
        private readonly Dictionary<string, Uri> _contexts;
        public HtmlTestApplication(TsiLoginHtmlContext tsiLoginHtmlContext)
        {
            Context = tsiLoginHtmlContext;
            _webPage = tsiLoginHtmlContext.webPage;
            _contexts = new Dictionary<string, Uri>
            {
                {"Login", new Uri("https://portaltest.titlesource.com/") },
                {"SwitchVendor", new Uri("https://portaltest.titlesource.com/Vendor/Admin/SwitchUserVendor.aspx")},
                {"OversightReview", new Uri("https://portaltest.titlesource.com/Vendor/Oversight/Queue.aspx")}
            };
        }

        public IContext Context { get; private set; }

        public bool NavigateToContext(string name)
        {
            if (_contexts.ContainsKey(name))
            {
                _webPage.NavigateToUrl(_contexts[name]);
            }
            else
            {
                return false;
            }
            return true;
        }
    }

    public class TsiLoginHtmlContext : IContext
    {
        internal BrowserWindow webPage;
        internal Dictionary<string, IControl> controls; 
        public TsiLoginHtmlContext(BrowserWindow browser)
        {
            webPage = browser;

        }
        public string Name
        {
            get { return webPage.Title; }
        }

        public IControl GetControlByName(string name)
        {
            if (controls.ContainsKey(name))
            {
                return controls[name];
            }
        }

        public IControl GetControlById(string id)
        {
            throw new NotImplementedException();
        }

        public string GetContentByName(string name)
        {
            throw new NotImplementedException();
        }

        public string GetContentById(string id)
        {
            throw new NotImplementedException();
        }
    }

    public static class ControlsLookup
    {
        
    }
}
