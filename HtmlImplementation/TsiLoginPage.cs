using TSUITest;

namespace HtmlImplementation
{
    public class TsiLoginPage : IViewContext
    {
        public TsiLoginPage(ITextSettable usernameTextSettable, ITextSettable passwordTextSettable, ILink submitButton)
        {
            _usernameTextBox = usernameTextSettable;
            _passwordTextBox = passwordTextSettable;
            _submitButton = submitButton;
        }

        private readonly ITextSettable _usernameTextBox;
        private readonly ITextSettable _passwordTextBox;
        private readonly ILink _submitButton;

        public void Run(string username, string password)
        {
            _usernameTextBox.Value = username;
            _passwordTextBox.Value = password;
            _submitButton.Click();
        }
    }
}