using System;
using CoreGraphics;
using Foundation;
using LNPopupController;
using ObjCRuntime;
using UIKit;

namespace LNPopupController
{
	// // @interface LNPopupBar : UIView <UIAppearanceContainer>
	[BaseType (typeof(UIView))]
	interface LNPopupBar : IUIAppearanceContainer
	{
		// @property (assign, nonatomic) BOOL inheritsAppearanceFromDockingView __attribute__((annotate("ui_appearance_selector")));
		[Export ("inheritsAppearanceFromDockingView")]
		bool InheritsAppearanceFromDockingView { get; set; }

		// @property (readonly, nonatomic, weak) int * _Nullable popupItem;
		[NullAllowed, Export ("popupItem", ArgumentSemantic.Weak)]
		unsafe IntPtr PopupItem { get; }

		// @property (readonly, copy, nonatomic) NSArray<UIBarButtonItem *> * _Nullable barButtonItems;
		[NullAllowed, Export ("barButtonItems", ArgumentSemantic.Copy)]
		UIBarButtonItem[] BarButtonItems { get; }

		// @property (readonly, copy, nonatomic) NSArray<UIBarButtonItem *> * _Nullable leadingBarButtonItems;
		[NullAllowed, Export ("leadingBarButtonItems", ArgumentSemantic.Copy)]
		UIBarButtonItem[] LeadingBarButtonItems { get; }

		// @property (readonly, copy, nonatomic) NSArray<UIBarButtonItem *> * _Nullable trailingBarButtonItems;
		[NullAllowed, Export ("trailingBarButtonItems", ArgumentSemantic.Copy)]
		UIBarButtonItem[] TrailingBarButtonItems { get; }

		// @property (readonly, nonatomic, strong) UIImageView * _Nonnull imageView;
		[Export ("imageView", ArgumentSemantic.Strong)]
		UIImageView ImageView { get; }

		// @property (assign, nonatomic) LNPopupBarStyle barStyle __attribute__((annotate("ui_appearance_selector")));
		[Export ("barStyle", ArgumentSemantic.Assign)]
		LNPopupBarStyle BarStyle { get; set; }

		// @property (copy, nonatomic) UI_APPEARANCE_SELECTOR int * standardAppearance __attribute__((annotate("ui_appearance_selector")));
		[Export ("standardAppearance", ArgumentSemantic.Copy)]
		unsafe IntPtr StandardAppearance { get; set; }

		// @property (assign, nonatomic) LNPopupBarProgressViewStyle progressViewStyle __attribute__((annotate("ui_appearance_selector")));
		[Export ("progressViewStyle", ArgumentSemantic.Assign)]
		LNPopupBarProgressViewStyle ProgressViewStyle { get; set; }

		// @property (readonly, nonatomic, strong) UIProgressView * _Nonnull progressView;
		[Export ("progressView", ArgumentSemantic.Strong)]
		UIProgressView ProgressView { get; }

		// @property (nonatomic) UISemanticContentAttribute barItemsSemanticContentAttribute;
		[Export ("barItemsSemanticContentAttribute", ArgumentSemantic.Assign)]
		UISemanticContentAttribute BarItemsSemanticContentAttribute { get; set; }

		// @property (readonly, nonatomic, strong) UITapGestureRecognizer * _Nonnull popupOpenGestureRecognizer;
		[Export ("popupOpenGestureRecognizer", ArgumentSemantic.Strong)]
		UITapGestureRecognizer PopupOpenGestureRecognizer { get; }

		// @property (readonly, nonatomic, strong) UILongPressGestureRecognizer * _Nonnull barHighlightGestureRecognizer;
		[Export ("barHighlightGestureRecognizer", ArgumentSemantic.Strong)]
		UILongPressGestureRecognizer BarHighlightGestureRecognizer { get; }

		// @property (nonatomic, strong) int * _Nullable customBarViewController;
		[NullAllowed, Export ("customBarViewController", ArgumentSemantic.Strong)]
		unsafe IntPtr CustomBarViewController { get; set; }
	}

	// // [Static]
	// // [Verify (ConstantsInterfaceAssociation)]
	// // partial interface Constants
	// // {
	// // 	// extern const UIBlurEffectStyle LNBackgroundStyleInherit;
	// // 	[Field ("LNBackgroundStyleInherit", "__Internal")]
	// // 	UIBlurEffectStyle LNBackgroundStyleInherit { get; }
	// // }

	// // @interface LNPopupBarAppearance : UIBarAppearance
	[BaseType (typeof(UIBarAppearance))]
	interface LNPopupBarAppearance
	{
		// @property (copy, nonatomic) NSDictionary<NSAttributedStringKey,id> * _Nullable titleTextAttributes;
		[NullAllowed, Export ("titleTextAttributes", ArgumentSemantic.Copy)]
		NSDictionary<NSString, NSObject> TitleTextAttributes { get; set; }

		// @property (copy, nonatomic) NSDictionary<NSAttributedStringKey,id> * _Nullable subtitleTextAttributes;
		[NullAllowed, Export ("subtitleTextAttributes", ArgumentSemantic.Copy)]
		NSDictionary<NSString, NSObject> SubtitleTextAttributes { get; set; }

		// @property (readwrite, copy, nonatomic) UIBarButtonItemAppearance * _Nonnull buttonAppearance;
		[Export ("buttonAppearance", ArgumentSemantic.Copy)]
		UIBarButtonItemAppearance ButtonAppearance { get; set; }

		// @property (readwrite, copy, nonatomic) UIBarButtonItemAppearance * _Nonnull doneButtonAppearance;
		[Export ("doneButtonAppearance", ArgumentSemantic.Copy)]
		UIBarButtonItemAppearance DoneButtonAppearance { get; set; }

		// @property (copy, nonatomic) UIColor * _Nonnull highlightColor;
		[Export ("highlightColor", ArgumentSemantic.Copy)]
		UIColor HighlightColor { get; set; }

		// @property (assign, nonatomic) BOOL marqueeScrollEnabled;
		[Export ("marqueeScrollEnabled")]
		bool MarqueeScrollEnabled { get; set; }

		// @property (assign, nonatomic) CGFloat marqueeScrollRate;
		[Export ("marqueeScrollRate")]
		nfloat MarqueeScrollRate { get; set; }

		// @property (assign, nonatomic) NSTimeInterval marqueeScrollDelay;
		[Export ("marqueeScrollDelay")]
		double MarqueeScrollDelay { get; set; }

		// @property (assign, nonatomic) BOOL coordinateMarqueeScroll;
		[Export ("coordinateMarqueeScroll")]
		bool CoordinateMarqueeScroll { get; set; }

		// -(void)configureWithDefaultMarqueeScroll;
		[Export ("configureWithDefaultMarqueeScroll")]
		void ConfigureWithDefaultMarqueeScroll ();

		// -(void)configureWithDisabledMarqueeScroll;
		[Export ("configureWithDisabledMarqueeScroll")]
		void ConfigureWithDisabledMarqueeScroll ();

		// -(void)configureWithDefaultHighlightColor;
		[Export ("configureWithDefaultHighlightColor")]
		void ConfigureWithDefaultHighlightColor ();
	}

	// @interface LNPopupCloseButton : UIButton <UIAppearanceContainer>
	[BaseType (typeof(UIButton))]
	interface LNPopupCloseButton : IUIAppearanceContainer
	{
		// @property (nonatomic) LNPopupCloseButtonStyle style __attribute__((annotate("ui_appearance_selector")));
		[Export ("style", ArgumentSemantic.Assign)]
		LNPopupCloseButtonStyle Style { get; set; }

		// @property (readonly, nonatomic, strong) UIVisualEffectView * _Nonnull backgroundView;
		[Export ("backgroundView", ArgumentSemantic.Strong)]
		UIVisualEffectView BackgroundView { get; }
	}

	// // @interface LNPopupContentView : UIView <UIAppearanceContainer>
	[BaseType (typeof(UIView))]
	interface LNPopupContentView : IUIAppearanceContainer
	{
		// @property (readonly, nonatomic, strong) UIPanGestureRecognizer * _Nonnull popupInteractionGestureRecognizer;
		[Export ("popupInteractionGestureRecognizer", ArgumentSemantic.Strong)]
		UIPanGestureRecognizer PopupInteractionGestureRecognizer { get; }

		// @property (nonatomic) LNPopupCloseButtonStyle popupCloseButtonStyle __attribute__((annotate("ui_appearance_selector")));
		[Export ("popupCloseButtonStyle", ArgumentSemantic.Assign)]
		LNPopupCloseButtonStyle PopupCloseButtonStyle { get; set; }

		// @property (readonly, nonatomic, strong) LNPopupCloseButton * _Nonnull popupCloseButton;
		[Export ("popupCloseButton", ArgumentSemantic.Strong)]
		LNPopupCloseButton PopupCloseButton { get; }

		// @property (copy, nonatomic) UI_APPEARANCE_SELECTOR UIBlurEffect * backgroundEffect __attribute__((annotate("ui_appearance_selector")));
		[Export ("backgroundEffect", ArgumentSemantic.Copy)]
		UIBlurEffect BackgroundEffect { get; set; }

		// @property (getter = isTranslucent, assign, nonatomic) BOOL translucent __attribute__((annotate("ui_appearance_selector")));
		[Export ("translucent")]
		bool Translucent { [Bind ("isTranslucent")] get; set; }
	}

	// // [Static]
	// // [Verify (ConstantsInterfaceAssociation)]
	// // partial interface Constants
	// // {
	// // 	// extern const UIBlurEffectStyle LNBackgroundStyleInherit;
	// // 	[Field ("LNBackgroundStyleInherit", "__Internal")]
	// // 	UIBlurEffectStyle LNBackgroundStyleInherit { get; }
	// // }

	// // @interface LNPopupCustomBarViewController : UIViewController <UIPointerInteractionDelegate>
	[BaseType (typeof(UIViewController))]
	interface LNPopupCustomBarViewController : IUIPointerInteractionDelegate
	{
		// @property (readonly, nonatomic, weak) LNPopupBar * _Nullable containingPopupBar;
		[NullAllowed, Export ("containingPopupBar", ArgumentSemantic.Weak)]
		LNPopupBar ContainingPopupBar { get; }

		// @property (readonly, assign, nonatomic) BOOL wantsDefaultTapGestureRecognizer;
		[Export ("wantsDefaultTapGestureRecognizer")]
		bool WantsDefaultTapGestureRecognizer { get; }

		// @property (readonly, assign, nonatomic) BOOL wantsDefaultPanGestureRecognizer;
		[Export ("wantsDefaultPanGestureRecognizer")]
		bool WantsDefaultPanGestureRecognizer { get; }

		// @property (readonly, assign, nonatomic) BOOL wantsDefaultHighlightGestureRecognizer;
		[Export ("wantsDefaultHighlightGestureRecognizer")]
		bool WantsDefaultHighlightGestureRecognizer { get; }

		// @property (assign, nonatomic) CGSize preferredContentSize;
		// [Export ("preferredContentSize", ArgumentSemantic.Assign)]
		// CGSize PreferredContentSize { get; set; }

		// // -(void)viewDidLoad __attribute__((objc_requires_super));
		// [Export ("viewDidLoad")]
		// [RequiresSuper]
		// void ViewDidLoad ();

		// -(void)popupItemDidUpdate;
		[Export ("popupItemDidUpdate")]
		void PopupItemDidUpdate ();

		// -(void)willMoveToPopupBar:(LNPopupBar * _Nullable)newPopupBar;
		[Export ("willMoveToPopupBar:")]
		void WillMoveToPopupBar ([NullAllowed] LNPopupBar newPopupBar);

		// -(void)didMoveToPopupBar;
		[Export ("didMoveToPopupBar")]
		void DidMoveToPopupBar ();

		// -(void)activeAppearanceDidChange:(LNPopupBarAppearance * _Nonnull)activeAppearance;
		[Export ("activeAppearanceDidChange:")]
		void ActiveAppearanceDidChange (LNPopupBarAppearance activeAppearance);
	}

	// // @interface LNPopupItem : NSObject
	[BaseType (typeof(NSObject))]
	interface LNPopupItem
	{
		// @property (copy, nonatomic) NSString * _Nullable title;
		[NullAllowed, Export ("title")]
		string Title { get; set; }

		// @property (copy, nonatomic) NS_REFINED_FOR_SWIFT NSAttributedString * attributedTitle __attribute__((swift_private));
		[Export ("attributedTitle", ArgumentSemantic.Copy)]
		NSAttributedString AttributedTitle { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable subtitle;
		[NullAllowed, Export ("subtitle")]
		string Subtitle { get; set; }

		// @property (copy, nonatomic) NS_REFINED_FOR_SWIFT NSAttributedString * attributedSubtitle __attribute__((swift_private));
		[Export ("attributedSubtitle", ArgumentSemantic.Copy)]
		NSAttributedString AttributedSubtitle { get; set; }

		// @property (nonatomic, strong) UIImage * _Nullable image;
		[NullAllowed, Export ("image", ArgumentSemantic.Strong)]
		UIImage Image { get; set; }

		// @property (nonatomic) float progress;
		[Export ("progress")]
		float Progress { get; set; }

		// @property (copy, nonatomic) NSArray<UIBarButtonItem *> * _Nullable barButtonItems;
		[NullAllowed, Export ("barButtonItems", ArgumentSemantic.Copy)]
		UIBarButtonItem[] BarButtonItems { get; set; }

		// -(void)setBarButtonItems:(NSArray<UIBarButtonItem *> * _Nullable)barButtonItems animated:(BOOL)animated;
		[Export ("setBarButtonItems:animated:")]
		void SetBarButtonItems ([NullAllowed] UIBarButtonItem[] barButtonItems, bool animated);

		// @property (copy, nonatomic) NSArray<UIBarButtonItem *> * _Nullable leadingBarButtonItems;
		[NullAllowed, Export ("leadingBarButtonItems", ArgumentSemantic.Copy)]
		UIBarButtonItem[] LeadingBarButtonItems { get; set; }

		// -(void)setLeadingBarButtonItems:(NSArray<UIBarButtonItem *> * _Nullable)leadingBarButtonItems animated:(BOOL)animated;
		[Export ("setLeadingBarButtonItems:animated:")]
		void SetLeadingBarButtonItems ([NullAllowed] UIBarButtonItem[] leadingBarButtonItems, bool animated);

		// @property (copy, nonatomic) NSArray<UIBarButtonItem *> * _Nullable trailingBarButtonItems;
		[NullAllowed, Export ("trailingBarButtonItems", ArgumentSemantic.Copy)]
		UIBarButtonItem[] TrailingBarButtonItems { get; set; }

		// -(void)setTrailingBarButtonItems:(NSArray<UIBarButtonItem *> * _Nullable)trailingBarButtonItems animated:(BOOL)animated;
		[Export ("setTrailingBarButtonItems:animated:")]
		void SetTrailingBarButtonItems ([NullAllowed] UIBarButtonItem[] trailingBarButtonItems, bool animated);

		// @property (readwrite, copy, nonatomic) LNPopupBarAppearance * _Nullable standardAppearance;
		[NullAllowed, Export ("standardAppearance", ArgumentSemantic.Copy)]
		LNPopupBarAppearance StandardAppearance { get; set; }
	}

	// // @interface Accessibility (LNPopupItem)
	[Category]
	[BaseType (typeof(LNPopupItem))]
	interface LNPopupItem_Accessibility
	{
		// @property (copy, nonatomic) NSString * _Nullable accessibilityImageLabel;
		[Export ("accessibilityImageLabel")]
		string AccessibilityImageLabel();

		// @property (copy, nonatomic) NSString * _Nullable accessibilityProgressLabel;
		[Export ("accessibilityProgressLabel")]
		string AccessibilityProgressLabel();

		// @property (copy, nonatomic) NSString * _Nullable accessibilityProgressValue;
		[Export ("accessibilityProgressValue")]
		string AccessibilityProgressValue();

		// @property (copy, nonatomic) NSString * _Nullable accessibilityImageLabel;
		[Export ("setAccessibilityImageLabel:")]
		void SetAccessibilityImageLabel(string value);

		// @property (copy, nonatomic) NSString * _Nullable accessibilityProgressLabel;
		[Export ("setAccessibilityProgressLabel:")]
		void SetAccessibilityProgressLabel(string value);

		// @property (copy, nonatomic) NSString * _Nullable accessibilityProgressValue;
		[Export ("setAccessibilityProgressValue:")]
		void SetAccessibilityProgressValue(string value);
	}

	// // [Static]
	// // [Verify (ConstantsInterfaceAssociation)]
	// // partial interface Constants
	// // {
	// // 	// extern const double LNSnapPercentDefault __attribute__((swift_private));
	// // 	[Field ("LNSnapPercentDefault", "__Internal")]
	// // 	double LNSnapPercentDefault { get; }
	// // }

	// // @interface LNPopupContent (UIViewController)
	[Category]
	[BaseType (typeof(UIViewController))]
	interface UIViewController_LNPopupContent
	{
		// @property (readonly, retain, nonatomic) LNPopupItem * _Nonnull popupItem;
		[Export ("popupItem")]
		LNPopupItem PopupItem();

		// @property (readonly, nonatomic, strong) __kindof UIView * _Nonnull viewForPopupInteractionGestureRecognizer;
		[Export ("viewForPopupInteractionGestureRecognizer")]
		UIView ViewForPopupInteractionGestureRecognizer();

		// -(BOOL)positionPopupCloseButton:(LNPopupCloseButton * _Nonnull)popupCloseButton;
		[Export ("positionPopupCloseButton:")]
		bool PositionPopupCloseButton (LNPopupCloseButton popupCloseButton);

		// -(void)viewWillMoveToPopupContainerContentView:(LNPopupContentView * _Nullable)popupContentView __attribute__((objc_requires_super));
		[Export ("viewWillMoveToPopupContainerContentView:")]
		[RequiresSuper]
		void ViewWillMoveToPopupContainerContentView ([NullAllowed] LNPopupContentView popupContentView);

		// -(void)viewDidMoveToPopupContainerContentView:(LNPopupContentView * _Nullable)popupContentView __attribute__((objc_requires_super));
		[Export ("viewDidMoveToPopupContainerContentView:")]
		[RequiresSuper]
		void ViewDidMoveToPopupContainerContentView ([NullAllowed] LNPopupContentView popupContentView);
	}

	// // @protocol LNPopupPresentationDelegate <NSObject>
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface LNPopupPresentationDelegate
	{
		// @optional -(void)popupPresentationControllerWillPresentPopupBar:(UIViewController * _Nonnull)popupPresentationController animated:(BOOL)animated;
		[Export ("popupPresentationControllerWillPresentPopupBar:animated:")]
		void PopupPresentationControllerWillPresentPopupBar (UIViewController popupPresentationController, bool animated);

		// @optional -(void)popupPresentationControllerDidPresentPopupBar:(UIViewController * _Nonnull)popupPresentationController animated:(BOOL)animated;
		[Export ("popupPresentationControllerDidPresentPopupBar:animated:")]
		void PopupPresentationControllerDidPresentPopupBar (UIViewController popupPresentationController, bool animated);

		// @optional -(void)popupPresentationControllerWillDismissPopupBar:(UIViewController * _Nonnull)popupPresentationController animated:(BOOL)animated;
		[Export ("popupPresentationControllerWillDismissPopupBar:animated:")]
		void PopupPresentationControllerWillDismissPopupBar (UIViewController popupPresentationController, bool animated);

		// @optional -(void)popupPresentationControllerDidDismissPopupBar:(UIViewController * _Nonnull)popupPresentationController animated:(BOOL)animated;
		[Export ("popupPresentationControllerDidDismissPopupBar:animated:")]
		void PopupPresentationControllerDidDismissPopupBar (UIViewController popupPresentationController, bool animated);

		// @optional -(void)popupPresentationController:(UIViewController * _Nonnull)popupPresentationController willOpenPopupWithContentController:(UIViewController * _Nonnull)popupContentController animated:(BOOL)animated;
		[Export ("popupPresentationController:willOpenPopupWithContentController:animated:")]
		void WillOpenPopupWithContentController (UIViewController popupPresentationController, UIViewController popupContentController, bool animated);

		// @optional -(void)popupPresentationController:(UIViewController * _Nonnull)popupPresentationController didOpenPopupWithContentController:(UIViewController * _Nonnull)popupContentController animated:(BOOL)animated;
		[Export ("popupPresentationController:didOpenPopupWithContentController:animated:")]
		void DidOpenPopupWithContentController (UIViewController popupPresentationController, UIViewController popupContentController, bool animated);

		// @optional -(void)popupPresentationController:(UIViewController * _Nonnull)popupPresentationController willClosePopupWithContentController:(UIViewController * _Nonnull)popupContentController animated:(BOOL)animated;
		[Export ("popupPresentationController:willClosePopupWithContentController:animated:")]
		void WillClosePopupWithContentController (UIViewController popupPresentationController, UIViewController popupContentController, bool animated);

		// @optional -(void)popupPresentationController:(UIViewController * _Nonnull)popupPresentationController didClosePopupWithContentController:(UIViewController * _Nonnull)popupContentController animated:(BOOL)animated;
		[Export ("popupPresentationController:didClosePopupWithContentController:animated:")]
		void PopupPresentationController (UIViewController popupPresentationController, UIViewController popupContentController, bool animated);

		// @optional -(void)popupPresentationControllerWillOpenPopup:(UIViewController * _Nonnull)popupPresentationController animated:(BOOL)animated __attribute__((deprecated("Use popupPresentationController:willOpenPopupWithContentController:animated: instead")));
		[Export ("popupPresentationControllerWillOpenPopup:animated:")]
		void PopupPresentationControllerWillOpenPopup (UIViewController popupPresentationController, bool animated);

		// @optional -(void)popupPresentationControllerDidOpenPopup:(UIViewController * _Nonnull)popupPresentationController animated:(BOOL)animated __attribute__((deprecated("Use popupPresentationController:didOpenPopupWithContentController:animated: instead")));
		[Export ("popupPresentationControllerDidOpenPopup:animated:")]
		void PopupPresentationControllerDidOpenPopup (UIViewController popupPresentationController, bool animated);

		// @optional -(void)popupPresentationControllerWillClosePopup:(UIViewController * _Nonnull)popupPresentationController animated:(BOOL)animated __attribute__((deprecated("Use popupPresentationController:willClosePopupWithContentController:animated: instead")));
		[Export ("popupPresentationControllerWillClosePopup:animated:")]
		void PopupPresentationControllerWillClosePopup (UIViewController popupPresentationController, bool animated);

		// @optional -(void)popupPresentationControllerDidClosePopup:(UIViewController * _Nonnull)popupPresentationController animated:(BOOL)animated __attribute__((deprecated("Use popupPresentationController:didClosePopupWithContentController:animated: instead")));
		[Export ("popupPresentationControllerDidClosePopup:animated:")]
		void PopupPresentationControllerDidClosePopup (UIViewController popupPresentationController, bool animated);
	}

	// // @interface LNPopupPresentation (UIViewController)
	[Category]
	[BaseType (typeof(UIViewController))]
	interface UIViewController_LNPopupPresentation
	{
		// -(void)presentPopupBarWithContentViewController:(UIViewController * _Nonnull)controller animated:(BOOL)animated completion:(void (^ _Nullable)(void))completion __attribute__((swift_async("none")));
		[Export ("presentPopupBarWithContentViewController:animated:completion:")]
		void PresentPopupBarWithContentViewController (UIViewController controller, bool animated, [NullAllowed] Action completion);

		// -(void)presentPopupBarWithContentViewController:(UIViewController * _Nonnull)controller openPopup:(BOOL)openPopup animated:(BOOL)animated completion:(void (^ _Nullable)(void))completion __attribute__((swift_async("none")));
		[Export ("presentPopupBarWithContentViewController:openPopup:animated:completion:")]
		void PresentPopupBarWithContentViewController (UIViewController controller, bool openPopup, bool animated, [NullAllowed] Action completion);

		// -(void)openPopupAnimated:(BOOL)animated completion:(void (^ _Nullable)(void))completion __attribute__((swift_async("none")));
		[Export ("openPopupAnimated:completion:")]
		void OpenPopupAnimated (bool animated, [NullAllowed] Action completion);

		// -(void)closePopupAnimated:(BOOL)animated completion:(void (^ _Nullable)(void))completion __attribute__((swift_async("none")));
		[Export ("closePopupAnimated:completion:")]
		void ClosePopupAnimated (bool animated, [NullAllowed] Action completion);

		// -(void)dismissPopupBarAnimated:(BOOL)animated completion:(void (^ _Nullable)(void))completion __attribute__((swift_async("none")));
		[Export ("dismissPopupBarAnimated:completion:")]
		void DismissPopupBarAnimated (bool animated, [NullAllowed] Action completion);

		// @property (assign, nonatomic) double popupSnapPercent __attribute__((swift_private));
		[Export ("popupInteractionStyle")]
		LNPopupInteractionStyle PopupInteractionStyle();

		[Export ("setPopupInteractionStyle:")]
		void SetPopupInteractionStyle(LNPopupInteractionStyle value);

		// @property (assign, nonatomic) double popupSnapPercent __attribute__((swift_private));
		[Export ("popupSnapPercent")]
		double PopupSnapPercent();

		[Export ("setPopupSnapPercent:")]
		void SetPopupSnapPercent(double value);

		// @property (assign, nonatomic) double popupSnapPercent __attribute__((swift_private));
		[Export ("popupBar")]
		LNPopupBar PopupBar();

		[Export ("setPopupBar:")]
		void SetLNPopupBar(LNPopupBar value);

		// // @property (assign, nonatomic) BOOL shouldExtendPopupBarUnderSafeArea;
		[Export ("shouldExtendPopupBarUnderSafeArea")]
		bool ShouldExtendPopupBarUnderSafeArea ();

		// // @property (assign, nonatomic) BOOL shouldExtendPopupBarUnderSafeArea;
		[Export ("setShouldExtendPopupBarUnderSafeArea:")]
		void SetShouldExtendPopupBarUnderSafeArea (bool value);

		// -(void)setNeedsPopupBarAppearanceUpdate;
		[Export ("setNeedsPopupBarAppearanceUpdate")]
		void SetNeedsPopupBarAppearanceUpdate ();

		// @property (readonly, nonatomic, strong) LNPopupContentView * _Nonnull popupContentView;
		[Export ("popupContentView", ArgumentSemantic.Strong)]
		LNPopupContentView PopupContentView();

		// @property (readonly, nonatomic) LNPopupPresentationState popupPresentationState;
		[Export ("popupPresentationState")]
		LNPopupPresentationState PopupPresentationState ();

		[Export ("popupPresentationDelegate")]
		LNPopupPresentationDelegate PopupPresentationDelegate();

		[Export ("setPopupPresentationDelegate:")]
		void SetPopupPresentationDelegate(LNPopupPresentationDelegate value);

		// // @property (nonatomic, weak) id<LNPopupPresentationDelegate> _Nullable popupPresentationDelegate;
		// [Export ("popupPresentationDelegate", ArgumentSemantic.Weak)]
		// NSObject WeakPopupPresentationDelegate { get; set; }

		// @property (readonly, nonatomic, strong) __kindof UIViewController * _Nullable popupContentViewController;
		[Export ("popupContentViewController")]
		UIViewController PopupContentViewController();

		// @property (readonly, nonatomic, weak) __kindof UIViewController * _Nullable popupPresentationContainerViewController;
		[Export ("popupPresentationContainerViewController")]
		UIViewController PopupPresentationContainerViewController();
	}

	// // @interface LNPopupCustomContainer (UIViewController)
	[Category]
	[BaseType (typeof(UIViewController))]
	interface UIViewController_LNPopupCustomContainer
	{
		// @property (readonly, nonatomic, strong) __kindof UIView * _Nullable bottomDockingViewForPopupBar;
		[Export ("bottomDockingViewForPopupBar")]
		UIView BottomDockingViewForPopupBar();

		// @property (readonly, assign, nonatomic) BOOL shouldFadePopupBarOnDismiss;
		[Export ("shouldFadePopupBarOnDismiss")]
		bool ShouldFadePopupBarOnDismiss();

		// @property (readonly, nonatomic) CGRect defaultFrameForBottomDockingView;
		[Export ("defaultFrameForBottomDockingView")]
		CGRect DefaultFrameForBottomDockingView();

		// @property (readonly, nonatomic) UIEdgeInsets insetsForBottomDockingView;
		[Export ("insetsForBottomDockingView")]
		UIEdgeInsets InsetsForBottomDockingView();
	}
}
