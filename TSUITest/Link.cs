namespace TSUITest
{
    public abstract class Link<T> :  ILink
    {
        public abstract void Click();

        protected Link(string propertyValue, string propertyName) : base(propertyValue, propertyName)
        {
        }
    }
}