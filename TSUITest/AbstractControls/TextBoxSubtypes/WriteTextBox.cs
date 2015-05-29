namespace TSUITest.AbstractControls.TextBoxSubtypes
{
    public abstract class WriteTextBox : TextBox, ITextSettable
    {
        public abstract string Value { set; }
        protected WriteTextBox(string propertyValue, string propertyName) : base(propertyValue, propertyName) {}
    }
}