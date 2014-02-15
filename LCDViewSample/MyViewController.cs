using System;
using MonoTouch.UIKit;
using System.Drawing;

namespace LCDViewSample
{
	public class MyViewController : UIViewController
	{
		UIButton button;
		LCDView view;
		int numClicks = 0;
		float buttonWidth = 321;
		float buttonHeight = 482;

		public MyViewController ()
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			View.Frame = UIScreen.MainScreen.Bounds;
			View.BackgroundColor = UIColor.White;
			View.AutoresizingMask = UIViewAutoresizing.FlexibleWidth | UIViewAutoresizing.FlexibleHeight;

			view = new LCDView ();

			view.Frame = new RectangleF (
			    View.Frame.Width / 2 - buttonWidth / 2,
			    View.Frame.Height / 2 - buttonHeight / 2,
			    buttonWidth,
			    buttonHeight);

			view.AutoresizingMask = UIViewAutoresizing.FlexibleWidth | UIViewAutoresizing.FlexibleTopMargin |
			    UIViewAutoresizing.FlexibleBottomMargin;

			View.AddSubview (view);
		}

	}
}

