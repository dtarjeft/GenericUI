using System.Collections.Generic;

namespace TSUITest
{
    public interface IFreeFormInput : IControl
    {
        string Value { get; set; }
    }

    public interface IToggle : IControl
    {
        bool Value { get; set; }
    }

    public interface IClickable : IControl
    {
        void Click();
    }
    public interface IHover : IControl
    {
        void Hover();
    }

    public interface IChoice : IControl
    {
        string Value { get; set; }

        string[] Choices { get; }
    }

    public interface ITestApplication
    {
        IContext Context { get; }

        bool NavigateToContext(string name);
    }

    public interface IContext
    {
        string Name { get; }
        IControl GetControlByName(string name);
        IControl GetControlById(string id);
        string GetContentByName(string name);
        string GetContentById(string id);
    }
}