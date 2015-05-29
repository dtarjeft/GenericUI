namespace TSUITest.Abstract_Controls.TextBoxSubtypes
{
    public abstract class WriteTextBox<T> : TextBox<T>, ITextSettable
    {
        public abstract string Value { set; }
        protected WriteTextBox(string propertyValue, string propertyName) : base(propertyValue, propertyName) {}
    }
}