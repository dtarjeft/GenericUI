using TSUITest;

namespace HtmlImplementation
{
    public class TsiLoginPage : IViewContext
    {
        public TsiLoginPage(IFreeFormInput usernameTextSettable, IFreeFormInput passwordTextSettable, IClickable submitButton)
        {
            _usernameTextBox = usernameTextSettable;
            _passwordTextBox = passwordTextSettable;
            _submitButton = submitButton;
        }

        private readonly IFreeFormInput _usernameTextBox;
        private readonly IFreeFormInput _passwordTextBox;
        private readonly IClickable _submitButton;

        public void Run(string username, string password)
        {
            _usernameTextBox.Value = username;
            _passwordTextBox.Value = password;
            _submitButton.Click();
        }
    }
}