namespace TSUITest.Abstract_Controls
{
    public abstract class TextBox<T> : Control<T>
    {
        protected TextBox(string propertyValue, string propertyName)
            : base(propertyValue, propertyName)
        {
        }
    }
}