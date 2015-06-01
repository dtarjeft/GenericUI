using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UITesting;
using TSUITest;

namespace HtmlImplementation
{
    public enum Contexts // Obviously (very) incomplete.
    {
        Invalid = 0,
        Login,
        Ribbon,
        LandingPage,
        SwitchVendor,
        OversightReview,
        
    }
    public class HtmlTestApplication : ITestApplication
    {
        private static BrowserWindow webPage;
        private readonly Dictionary<Contexts, IContext> contexts;
        private List<IDisposable> unsubscriptors;
        
        public HtmlTestApplication(BrowserWindow webPage)
        {
            HtmlTestApplication.webPage = webPage;
            
            contexts = new Dictionary<Contexts, IContext> // This setup should maybe instead be a factory method..?
            {
                {Contexts.Login, new TsiLoginHtmlContext(webPage) },
                {Contexts.LandingPage, new TsiLandingPage(webPage) },
                {Contexts.SwitchVendor, new TsiSwitchVendorHtmlContext(webPage)},
                {Contexts.OversightReview, new TsiOversightReview(webPage)}
            };
            unsubscriptors = new List<IDisposable>(); 
            
            /* I'd like a better way to do the following than establishing all the 
             * Context links right here... but I'm not sure how that'd work,
             * given that this implementation is newing up controls and contexts concurrently.
             * 
             * Ideally: Controls with a Context link are established in their own classes.
             */
            contexts[Contexts.Login].Controls["Login"].DestinationContext = contexts[Contexts.LandingPage];
            contexts[Contexts.LandingPage].Controls["SwitchVendor"].DestinationContext = contexts[Contexts.SwitchVendor];
            contexts[Contexts.LandingPage].Controls["OversightReview"].DestinationContext =
                contexts[Contexts.OversightReview];

        }
        public IContext Context { get; private set; }

        /// <summary>
        /// Attempts to navigate to the given Context (if it exists) without respect to UI Nav or Application State/Data.
        /// 
        /// Thus, don't bother trying to skip straight to something within the website if you're not logged in. Your test will fail.
        /// </summary>
        public bool NavigateToContext(string namestr)
        {
            var name = (Contexts) Enum.Parse(typeof (Contexts), namestr);
            if (contexts.ContainsKey(name))
            {
                foreach (var unsubscriptor in unsubscriptors)
                {
                    unsubscriptor.Dispose();
                }
                unsubscriptors = new List<IDisposable>();

                var controlDict = contexts[name].Controls;
                foreach (var nCv in controlDict.Select(nextControl => nextControl.Value)) {
                    unsubscriptors.Add(nCv.Subscribe(this));
                }
                Context = contexts[name];
                webPage.NavigateToUrl(new Uri(Context.GetContentByName("Uri")));
            }
            else
            {
                return false;
            }
            return true;
        }

        public void OnNext(IContext value)
        {
            var checkControl = (IClickable) this.Context.GetControlByName("Login");
            /* 
             * Pavlak's control state logic will go great here... 
             *     so I just put in the jankiest answer I could write in 0 seconds.
             * 
             * Should eventually wind up something like:
             *                         "if (!checkControl.isActionable){Context = value;}
             *                          else { // Change Context to something else or keep it the same, depending on the web page. }"
             */
            try // Til then: 
            {
                checkControl.Click(); // Nav away from Google, then Continue test.
            }
            catch (Exception) // Kludge-a-riffic!
            {
                Context = value;
            }
        }

        /* Not sure what to do with these.. might be overkill for our needs? Regular "event" elements may be in order? Need some syntax help with those.
         */
        public void OnError(Exception error)
        {
            throw new NotImplementedException();
        }

        public void OnCompleted()
        {
            throw new NotImplementedException();
        }
    }
}