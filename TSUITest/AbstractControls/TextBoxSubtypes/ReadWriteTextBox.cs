namespace TSUITest.Abstract_Controls.TextBoxSubtypes
{
    public abstract class ReadWriteTextBox<T> : TextBox<T>, ITextSettable, ITextGettable
    {

        public abstract string Value { get; set; }
        protected ReadWriteTextBox(string propertyValue, string propertyName) : base(propertyValue, propertyName) {}
    }
}