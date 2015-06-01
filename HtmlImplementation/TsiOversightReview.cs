using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UITesting;
using TSUITest;

namespace HtmlImplementation
{
    public class TsiOversightReview : IContext
    {
        internal BrowserWindow WebPage;
        public Dictionary<string, IControl> Controls { get; private set; }
        public TsiOversightReview(BrowserWindow webPage)
        {
            WebPage = webPage;
        }

        public string Name
        {
            get { return Contexts.OversightReview.ToString(); }
        }

        public IControl GetControlByName(string name)
        {
            throw new NotImplementedException();
        }

        public string GetContentByName(string name)
        {
            return name == "Uri" ? "https://portaltest.titlesource.com/Vendor/Oversight/Queue.aspx" : string.Empty;
        }
    }
}