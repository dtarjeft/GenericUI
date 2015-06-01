using System;

namespace TSUITest
{
    /// <summary>
    /// Describes a Application that has an IContext and the ability to change Contexts.
    /// </summary>
    public interface ITestApplication : IObserver<IContext>
    {
        IContext Context { get; }
        bool NavigateToContext(string name);
    }
}