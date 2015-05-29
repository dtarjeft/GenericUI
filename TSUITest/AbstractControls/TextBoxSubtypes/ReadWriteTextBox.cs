namespace TSUITest.AbstractControls.TextBoxSubtypes
{
    public abstract class ReadWriteTextBox : TextBox, ITextSettable, ITextGettable
    {

        public abstract string Value { get; set; }
        protected ReadWriteTextBox(string propertyValue, string propertyName) : base(propertyValue, propertyName) {}
    }
}