using System;
using UIKit;
using Foundation;

namespace Xamarin.iOSBinding
{
	public class RootViewController:UIViewController
	{
		public RootViewController ()
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			View.BackgroundColor = UIColor.White;

			var lbl = new WrapperLabel (new CoreGraphics.CGRect (100, 100, 200, 100));
			lbl.Text = "This is a text label";
			Add (lbl);
		}
	}
}
