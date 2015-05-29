using System;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;
using TSUITest;
using TSUITest.Abstract_Controls;

namespace HtmlImplementation
{
    public class TsiHtmlLink : Link<HtmlControl>
    {
        public TsiHtmlLink(UITestControl browser, string propertyValue, string propertyName = "id") : base(propertyValue, propertyName)
        {
            Self = (HtmlControl)TsiHtmlTestHelpers.Find(PropertyKeyValuePair, new HtmlControl(browser));
        }
        public override void Click()
        {
            Self.WaitForControlReady();
            Mouse.Click(Self);
        }
    }
}