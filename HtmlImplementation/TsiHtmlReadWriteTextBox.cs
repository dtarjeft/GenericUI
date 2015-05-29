using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;
using TSUITest;

namespace HtmlImplementation
{
    public class TsiHtmlReadWriteTextBox : ReadWriteTextBox<HtmlEdit>
    {
        public TsiHtmlReadWriteTextBox(UITestControl parentControl, string propertyValue, string propertyName = "id") : base(propertyValue, propertyName)
        {
            Self = (HtmlEdit) TsiHtmlTestHelpers.Find(PropertyKeyValuePair, new HtmlEdit(parentControl));
        }
        public override string Value
        {
            get { return Self.Text; }
            set
            {
                Self.WaitForControlReady();
                Self.Text = value;
            }
        }
    }
}