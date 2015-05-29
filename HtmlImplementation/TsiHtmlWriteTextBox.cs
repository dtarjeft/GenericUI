using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;
using TSUITest;
using TSUITest.AbstractControls.TextBoxSubtypes;

namespace HtmlImplementation
{
    public class TsiHtmlWriteTextBox : WriteTextBox
    {
        public TsiHtmlWriteTextBox(UITestControl parentControl, string propertyValue, string propertyName = "id") : base(propertyValue, propertyName)
        {
            Self = (HtmlEdit) TsiHtmlTestHelpers.Find(PropertyKeyValuePair, new HtmlEdit(parentControl));
        }
        public override string Value
        {
            set
            {
                Self.WaitForControlReady();
                Self.Text = value;
            }
        }
    }
}