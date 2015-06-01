using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;
using TSUITest;

namespace HtmlImplementation
{
    public class TsiLoginHtmlContext : IContext
    {
        public Dictionary<string, IControl> Controls { get; private set; }
        public TsiLoginHtmlContext(UITestControl browser)
        {
            var containerDiv = new HtmlDiv(browser); // Constrain the search for the controls you care about here-- assuming efficiency is a concern.
            containerDiv.AddSearchPropertiesToControl(HtmlControl.PropertyNames.Id, "Iforgot",
                HtmlControl.PropertyNames.Name, "whocares"); // As many search parameters as you want!
            Controls = new Dictionary<string, IControl> // Instead of this for our WPF implementation.. We could search our XML docs for the controls we care about.
            {
                {"Username", new TsiHtmlTextBox(containerDiv, HtmlControl.PropertyNames.Id, "lst-ib", UITestControl.PropertyNames.Name, "q")},
                {"Password", new TsiHtmlTextBox(containerDiv, HtmlControl.PropertyNames.Id, "lst-ib", UITestControl.PropertyNames.Name, "q")},
                {"Login", new TsiButton(containerDiv, UITestControl.PropertyNames.Name, "btnG")}
            };
        }

        public string Name
        {
            get { return Contexts.Login.ToString(); }
        }
        public IControl GetControlByName(string name)
        {
            return Controls.ContainsKey(name) ? Controls[name] : null;
        }

        public string GetContentByName(string name)
        {
            return name == "Uri" ? "https://www.google.com/" : string.Empty;
        }
    }
}