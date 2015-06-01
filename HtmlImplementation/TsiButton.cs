using System;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;
using TSUITest;

namespace HtmlImplementation
{
    public class TsiButton : IClickable
    {
        private readonly HtmlControl self;

        private IObserver<IContext> observer;
        public IContext DestinationContext { get; set; }

        public TsiButton(UITestControl parent, params string[] searchPairs)
        {
            self = (HtmlControl) new HtmlControl(parent).AddSearchPropertiesToControl(searchPairs);
        }

        public void Click()
        {
            self.WaitForControlReady();
            Mouse.Click(self);
            observer.OnNext(DestinationContext); // Throws an event to subscribed observers. This implementation's observer_ is HtmlTestApplication.
        }

        public IDisposable Subscribe(IObserver<IContext> observer_)
        {
            this.observer = observer_;
            return new Unsubscriber(this.observer);
        }
    }

    public class Unsubscriber : IDisposable
    {
        private readonly IObserver<IContext> observer;
        public Unsubscriber(IObserver<IContext> _observer)
        {
            observer = _observer;
        }
        public void Dispose()
        {

        }
    }
}