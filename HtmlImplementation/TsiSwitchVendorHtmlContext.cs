using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;
using TSUITest;

namespace HtmlImplementation
{
    public class TsiSwitchVendorHtmlContext : TsiRibbon
    {
        public TsiSwitchVendorHtmlContext(BrowserWindow webPage) : base(webPage)
        {
            Controls.Add("VendorEntry", new TsiHtmlTextBox(WebPage, HtmlEdit.PropertyNames.Id, "CrappyPlaceholderGuy"));
            Controls.Add("Switch", new TsiButton(WebPage, HtmlButton.PropertyNames.Id, "CrappyPlaceholderGuy2"));
            Controls.Add("Close", new TsiButton(WebPage, HtmlButton.PropertyNames.Id, "CrappyPlaceholderGuy3"));
        }

        public override string Name
        {
            get { return Contexts.SwitchVendor.ToString(); }
        }

        public override string GetContentByName(string name)
        {
            return name == "Uri" ? "https://portaltest.titlesource.com/Vendor/Admin/SwitchUserVendor.aspx" : string.Empty;
        }
    }
}