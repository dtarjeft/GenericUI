using TSUITest.Abstract_Controls;

namespace TSUITest
{
    public abstract class Link<T> : Control<T>, ILink
    {
        public abstract void Click();

        protected Link(string propertyValue, string propertyName) : base(propertyValue, propertyName)
        {
        }
    }
}