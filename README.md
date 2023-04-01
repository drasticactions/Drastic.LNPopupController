[![NuGet Version](https://img.shields.io/nuget/v/Drastic.LNPopupController.svg)](https://www.nuget.org/packages/Drastic.LNPopupController/) ![License](https://img.shields.io/badge/License-MIT-blue.svg)

# Drastic.LNPopupController

Drastic.LNPopupController is a .NET iOS and Catalyst binding of [LNPopupController](https://github.com/LeoNatan/LNPopupController), a framework for presenting view controllers as popups of other view controllers.

# Setup

- Install the `Drastic.LNPopupController`

- Add the `LNPopupController` namespace to your code. This will expose additional properties on your `UIViewController` and `UIView`s

```csharp
...
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
        public DemoPopupContentViewController()
        {
        }
    }
...
```