using Microsoft.VisualStudio.TestTools.UITesting;
using TSUITest;

namespace HtmlImplementation
{
    public class TsiLoginPage : IViewContext
    {
        public BrowserWindow Browser { get; set; }
        public TsiLoginPage(BrowserWindow browser)
        {
            Browser = browser;
        }
        public TsiHtmlReadWriteTextBox UsernameTextBox;
        public TsiHtmlWriteTextBox PasswordTextBox;
        public TsiHtmlButton SubmitButton;
    }
}