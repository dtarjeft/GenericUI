using System.Collections.Generic;

namespace TSUITest.Abstract_Controls
{
    public abstract class Button<T> : IButton
    {
        protected Button(string propertyValue, string propertyName)
        {
            PropertyKeyValuePair = new KeyValuePair<string, string>(propertyName, propertyValue);
        }
        protected T Self { get; set; }
        public KeyValuePair<string, string> PropertyKeyValuePair { get; protected set; }
        public abstract void Push();
    }
}