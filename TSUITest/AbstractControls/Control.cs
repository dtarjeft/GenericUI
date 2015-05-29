using System.Collections.Generic;

namespace TSUITest.AbstractControls
{
    public abstract class Control : IControl
    {
        protected Control(string propertyValue, string propertyName)
        {
            PropertyKeyValuePair = new KeyValuePair<string, string>(propertyName, propertyValue);
        }
        protected T Self { get; set; }
        public KeyValuePair<string, string> PropertyKeyValuePair { get; protected set; }
    }
}