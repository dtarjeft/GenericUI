namespace TSUITest.AbstractControls.TextBoxSubtypes
{
    public abstract class ReadTextBox : TextBox, ITextGettable
    {
        protected ReadTextBox(string propertyValue, string propertyName) : base(propertyValue, propertyName) {}

        public abstract string Value { get; }
    }
}