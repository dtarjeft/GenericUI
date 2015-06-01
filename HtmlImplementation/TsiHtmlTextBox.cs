using System;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;
using TSUITest;

namespace HtmlImplementation
{
    public class TsiHtmlTextBox: IFreeFormInput
    {
        private HtmlEdit _self;
        public TsiHtmlTextBox(UITestControl parent, params string[] str)
        {
            _self = (HtmlEdit) new HtmlEdit(parent).AddSearchPropertiesToControl(str);
        }

        public string Value
        {
            get { return _self.Text; }
            set { _self.Text = value; }
        }

        public IDisposable Subscribe(IObserver<IContext> observer)
        {
            return new Unsubscriber(observer);
        }

        public IContext DestinationContext { get; set; }
    }
}