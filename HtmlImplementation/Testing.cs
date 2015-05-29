using System;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HtmlImplementation
{
    [CodedUITest]
    public class Testing
    {
        [TestMethod]
        public void ToGoogle()
        {
            var browser = BrowserWindow.Launch(new Uri("http://www.google.com"));
            var tsiTest = new TsiLoginPage(browser)
            {
                UsernameTextBox = new TsiHtmlReadWriteTextBox(browser, "q", "name"),
                PasswordTextBox = new TsiHtmlWriteTextBox(browser, "q","name"),
                SubmitButton = new TsiHtmlButton(browser, "btnG", "name")
            };

            tsiTest.PasswordTextBox.Value = "Implementation test";
            tsiTest.SubmitButton.Push();
        }
    }
}
