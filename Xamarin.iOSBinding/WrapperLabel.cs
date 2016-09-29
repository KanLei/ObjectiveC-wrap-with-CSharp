using System;
using UIKit;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace Xamarin.iOSBinding
{
	[Register("UILabel")]  //  1
	public class WrapperLabel:UIView
	{
		// 2
		private static readonly IntPtr class_ptr = Class.GetHandle ("UILabel");
		

		[Export ("initWithFrame:")]
		public WrapperLabel (CGRect frame):base(NSObjectFlag.Empty)
		{
			UIApplication.EnsureUIThread ();
			if (base.IsDirectBinding) {
				base.InitializeHandle (Messaging.IntPtr_objc_msgSend_CGRect (base.Handle, Selector.GetHandle ("initWithFrame:"), frame), "initWithFrame:");
			}
			else {
				base.InitializeHandle (Messaging.IntPtr_objc_msgSendSuper_CGRect (base.SuperHandle, Selector.GetHandle ("initWithFrame:"), frame), "initWithFrame:");
			}
		}

		public virtual string Text
		{
			[Export("text")]
			get {
				UIApplication.EnsureUIThread ();
				if (base.IsDirectBinding) {
					return NSString.FromHandle (Messaging.IntPtr_objc_msgSend (base.Handle, Selector.GetHandle ("text")));
				}
				return NSString.FromHandle (Messaging.IntPtr_objc_msgSendSuper (base.SuperHandle, Selector.GetHandle ("text")));
			}
			[Export("setText:")]
			set {
				UIApplication.EnsureUIThread ();
				IntPtr ptr = NSString.CreateNative (value);
				if (base.IsDirectBinding) {
					Messaging.void_objc_msgSend_IntPtr (base.Handle, Selector.GetHandle ("setText:"), ptr);
				} else {
					Messaging.void_objc_msgSendSuper_IntPtr (base.SuperHandle, Selector.GetHandle ("setText:"), ptr);
				}
				NSString.ReleaseNative (ptr);
			}
		}

		// 3
		public override IntPtr ClassHandle {
			get {
				return class_ptr;
			}
		}
	}
}
