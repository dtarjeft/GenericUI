using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UITesting;

namespace HtmlImplementation
{
    public static class TsiHtmlTestHelpers
    {
        public static UITestControl Find(string propertyValue, string propertyName, UITestControl control)
        {
            control.SearchProperties.Add(propertyName, propertyValue);
            return control;
        }
        public static UITestControl Find(KeyValuePair<string, string> propertyKeyValuePair, UITestControl control)
        {
            return Find(propertyKeyValuePair.Value, propertyKeyValuePair.Key, control);
        }
    }
}