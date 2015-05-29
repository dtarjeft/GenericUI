using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;
using TSUITest;
using TSUITest.Abstract_Controls;

namespace HtmlImplementation
{
    public class TsiHtmlButton : Button<HtmlButton>
    {
        public TsiHtmlButton(UITestControl parentControl, string propertyValue, string propertyName = "id") : base(propertyValue, propertyName)
        {
            Self = (HtmlButton) TsiHtmlTestHelpers.Find(PropertyKeyValuePair, new HtmlButton(parentControl));
        }
        public override void Push()
        {
            Self.WaitForControlReady();
            Mouse.Click(Self);
        }
    }
}