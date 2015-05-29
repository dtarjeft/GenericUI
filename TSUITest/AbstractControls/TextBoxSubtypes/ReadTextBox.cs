namespace TSUITest.Abstract_Controls.TextBoxSubtypes
{
    public abstract class ReadTextBox<T> : TextBox<T>, ITextGettable
    {
        protected ReadTextBox(string propertyValue, string propertyName) : base(propertyValue, propertyName) {}

        public abstract string Value { get; }
    }
}