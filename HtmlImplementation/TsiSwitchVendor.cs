using TSUITest;

namespace HtmlImplementation
{
    public class TsiSwitchVendor : IViewContext
    {
        private readonly ILink _switchVendorPageLink;
        private readonly ITextSettable _switchVendorTextSettable;
        private readonly IButton _switchButton;
        private readonly IButton _closeButton;

        public TsiSwitchVendor(ILink vendorPageLink, ITextSettable vendorSwitchTextBox, IButton switchButton, IButton closeButton)
        {
            _switchVendorPageLink = vendorPageLink;
            _switchVendorTextSettable = vendorSwitchTextBox;
            _switchButton = switchButton;
            _closeButton = closeButton;
        }

        public void Run(string vendorNumber)
        {
            _switchVendorPageLink.Click();
            _switchVendorTextSettable.Value = vendorNumber;
            _switchButton.Push();
            _closeButton.Push();
        }
    }
}