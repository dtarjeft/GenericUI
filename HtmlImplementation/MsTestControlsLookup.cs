using Microsoft.VisualStudio.TestTools.UITesting;

namespace HtmlImplementation
{
    public static class MsTestControlsLookup
    {
        public static UITestControl AddSearchPropertiesToControl(this UITestControl control, params string[] str)
        {
            for (var i = 0; i < str.Length-1; i+=2)
            {
                control.SearchProperties.Add(str[i], str[i+1]);
            }
            return control;
        }
    }
}