using System;
using ObjCRuntime;
using LNPopupController;

namespace Drastic.LNPopupControllerSample
{
    public class TestViewController : UITabBarController
    {
        public TestViewController()
        {
        }

        public TestViewController(NSCoder coder) : base(coder)
        {
        }

        public TestViewController(string? nibName, NSBundle? bundle) : base(nibName, bundle)
        {
        }

        protected TestViewController(NSObjectFlag t) : base(t)
        {
        }

        protected internal TestViewController(NativeHandle handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            var test = new DemoPopupContentViewController();
            test.PopupItem().Title = "Test!";
            this.PresentPopupBarWithContentViewController(test, true, null);
        }
    }

    public class DemoPopupContentViewController : UIViewController
    {
        //public LNPopupItem PopupItem { get; set; } = new LNPopupItem();

        public DemoPopupContentViewController()
        {
        }
    }
}

