using System.Collections.Generic;

namespace TSUITest
{
    public interface ITextSettable : IControl
    {
        string Value { set; }
    }
    public interface ITextGettable : IControl
    {
        string Value { get; }
    }
    public interface IButton : IControl
    {
        void Push();
    }
    public interface ILink : IControl
    {
        void Click();
    }
    public interface IListContainer<out T> : IControl
    {
        IEnumerable<T> Items { get; }
    }
    public interface IHover : IControl
    {
        void Hover();
    }
}