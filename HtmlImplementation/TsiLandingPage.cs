using System;
using System.Collections.Generic;
using System.Drawing.Text;
using Microsoft.VisualStudio.TestTools.UITesting;
using TSUITest;

namespace HtmlImplementation
{
    public class TsiRibbon : IContext
    {
        internal BrowserWindow WebPage;
        public TsiRibbon(BrowserWindow webPage)
        {
            WebPage = webPage;
            Controls = new Dictionary<string, IControl>(); // TODO: Ribbon Bar Context linkages.
        }

        public virtual string Name
        {
            get { return Contexts.Ribbon.ToString(); }
        }

        public Dictionary<string, IControl> Controls { get; protected set; }

        public IControl GetControlByName(string name)
        {
            return Controls.ContainsKey(name) ? Controls[name] : null;
        }

        public virtual string GetContentByName(string name)
        {
            throw new NotImplementedException();
        }
    }

    public class TsiLandingPage : TsiRibbon
    {
        public TsiLandingPage(BrowserWindow webPage) : base(webPage)
        {
            // TODO: Add other stuff from the Landing Page here.
        }

        public override string Name
        {
            get { return Contexts.LandingPage.ToString(); }
        }
    }
}