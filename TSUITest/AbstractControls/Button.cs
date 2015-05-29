namespace TSUITest.AbstractControls
{
    public abstract class Button : Control, IButton
    {
        protected Button(string propertyValue, string propertyName)
            : base(propertyName, propertyValue)
        {
        }
        public abstract void Push();
    }
    
}