using System.Collections.Generic;

namespace TSUITest.Abstract_Controls
{
    public abstract class Button<T> : Control<T>, IButton
    {
        protected Button(string propertyValue, string propertyName)
            : base(propertyName, propertyValue)
        {
        }
        public abstract void Push();
    }
    
}