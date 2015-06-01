using System.Collections.Generic;

namespace TSUITest
{
    /// <summary>
    /// Describes a state of an ITestApplication. Exposes methods of acquiring child IControls by name. 
    /// Tests are written with the colloquial name, so an Html implementation's Username TextBox/HtmlEdit is "Username"
    /// </summary>
    public interface IContext
    {
        string Name { get; }
        Dictionary<string, IControl> Controls { get; }

        IControl GetControlByName(string name);
        string GetContentByName(string name);
    }
}