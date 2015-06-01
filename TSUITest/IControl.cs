using System;

namespace TSUITest
{
    /// <summary>
    /// Describes a Control that may change the Context of an ITestApplication.
    /// </summary>
    public interface IControl : IObservable<IContext>
    {
        IContext DestinationContext { get; set; }
    }
    #region IControl SubInterfaces!
    /// <summary>
    /// Exposes a method for getting and setting strings from an IControl in a UI.
    /// </summary>
    public interface IFreeFormInput : IControl
    {
        string Value { get; set; }
    }
    /// <summary>
    /// Exposes a method for getting/setting the state of a toggleable IControl.
    /// </summary>
    public interface IToggle : IControl
    {
        bool Value { get; set; }
    }
    /// <summary>
    /// Exposes a method for mouse clicks on IControls in a UI.
    /// </summary>
    public interface IClickable : IControl
    {
        void Click();
    }
    /// <summary>
    /// Exposes a method for mouse hovering on IControls in a UI.
    /// </summary>
    public interface IHover : IControl
    {
        void Hover();
    }
    /// <summary>
    /// Exposes properties related to Combo Boxes/Expansions in a UI.
    /// </summary>
    public interface IChoice : IControl
    {
        string Value { get; set; }

        string[] Choices { get; }
    }
    #endregion
}