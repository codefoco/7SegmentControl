using System;
using System.Drawing;

using MonoTouch.CoreGraphics;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace LCDViewSample
{
	[Register ("UIView1")]
	public class LCDView : UIView
	{
		public LCDView ()
		{
			Initialize ();
		}

		public LCDView (RectangleF bounds)
			: base (bounds)
		{
			Initialize ();
		}

		void Initialize ()
		{
			BackgroundColor = UIColor.Red;
		}

		public override void Draw (RectangleF rect)
		{
			base.Draw (rect);

			//// General Declarations
			var colorSpace = CGColorSpace.CreateDeviceRGB ();
			var context = UIGraphics.GetCurrentContext ();

			//// Color Declarations
			UIColor color9 = UIColor.FromRGBA (0.988f, 0.276f, 0.228f, 1.000f);
			UIColor color5 = UIColor.FromRGBA (0.914f, 0.000f, 0.027f, 1.000f);
			UIColor color12 = UIColor.FromRGBA (0.696f, 0.077f, 0.135f, 0.500f);
			UIColor color4 = UIColor.FromRGBA (0.696f, 0.077f, 0.135f, 0.300f);
			UIColor color0 = UIColor.FromRGBA (0.215f, 0.215f, 0.215f, 1.000f);
			UIColor color3 = UIColor.FromRGBA (0.000f, 0.000f, 0.000f, 1.000f);
			UIColor color2 = UIColor.FromRGBA (0.033f, 0.033f, 0.033f, 1.000f);
			UIColor color11 = UIColor.FromRGBA (0.988f, 0.349f, 0.302f, 1.000f);
			UIColor color10 = UIColor.FromRGBA (0.952f, 0.000f, 0.028f, 1.000f);
			UIColor color1 = UIColor.FromRGBA (0.071f, 0.071f, 0.071f, 1.000f);
			UIColor color7 = UIColor.FromRGBA (0.986f, 0.000f, 0.045f, 1.000f);
			UIColor color6 = UIColor.FromRGBA (0.987f, 0.255f, 0.212f, 1.000f);
			UIColor color8 = UIColor.FromRGBA (0.986f, 0.000f, 0.029f, 1.000f);
			UIColor color13 = UIColor.FromRGBA (0.986f, 0.097f, 0.029f, 1.000f);

			//// Gradient Declarations
			var linearGradient4854Colors = new CGColor [] { color8.CGColor, color9.CGColor, color10.CGColor };
			var linearGradient4854Locations = new float [] { 0, 0.52f, 1 };
			var linearGradient4854 = new CGGradient (colorSpace, linearGradient4854Colors, linearGradient4854Locations);
			var background_1_Colors = new CGColor [] { color0.CGColor, color1.CGColor, color2.CGColor, color3.CGColor };
			var background_1_Locations = new float [] { 0, 0.45f, 0.71f, 1 };
			var background_1_ = new CGGradient (colorSpace, background_1_Colors, background_1_Locations);
			var linearGradient4902Colors = new CGColor [] { color5.CGColor, color6.CGColor, color7.CGColor };
			var linearGradient4902Locations = new float [] { 0, 0.68f, 1 };
			var linearGradient4902 = new CGGradient (colorSpace, linearGradient4902Colors, linearGradient4902Locations);
			var linearGradient4870Colors = new CGColor [] { color8.CGColor, color11.CGColor, color10.CGColor };
			var linearGradient4870Locations = new float [] { 0, 0.69f, 1 };
			var linearGradient4870 = new CGGradient (colorSpace, linearGradient4870Colors, linearGradient4870Locations);
			var linearGradient4840Colors = new CGColor [] { color5.CGColor, color6.CGColor, color7.CGColor };
			var linearGradient4840Locations = new float [] { 0, 0.68f, 1 };
			var linearGradient4840 = new CGGradient (colorSpace, linearGradient4840Colors, linearGradient4840Locations);
			var linearGradient4910Colors = new CGColor [] { color8.CGColor, color9.CGColor, color10.CGColor };
			var linearGradient4910Locations = new float [] { 0, 0.52f, 1 };
			var linearGradient4910 = new CGGradient (colorSpace, linearGradient4910Colors, linearGradient4910Locations);
			var linearGradient4894Colors = new CGColor [] { color5.CGColor, color6.CGColor, color7.CGColor };
			var linearGradient4894Locations = new float [] { 0, 0.68f, 1 };
			var linearGradient4894 = new CGGradient (colorSpace, linearGradient4894Colors, linearGradient4894Locations);
			var linearGradient4886Colors = new CGColor [] { color5.CGColor, color6.CGColor, color7.CGColor };
			var linearGradient4886Locations = new float [] { 0, 0.68f, 1 };
			var linearGradient4886 = new CGGradient (colorSpace, linearGradient4886Colors, linearGradient4886Locations);

			//// Bezier Drawing
			UIBezierPath bezierPath = new UIBezierPath ();
			bezierPath.MoveTo (new PointF (0, 0));
			bezierPath.AddLineTo (new PointF (321, 0));
			bezierPath.AddLineTo (new PointF (321, 481.92f));
			bezierPath.AddLineTo (new PointF (0, 481.92f));
			bezierPath.AddLineTo (new PointF (0, 0));
			bezierPath.ClosePath ();
			bezierPath.MiterLimit = 4;

			context.SaveState ();
			bezierPath.AddClip ();
			context.DrawLinearGradient (background_1_,
			    new PointF (160.5f, 481.92f),
			    new PointF (160.5f, 2.75f),
			    CGGradientDrawingOptions.DrawsBeforeStartLocation | CGGradientDrawingOptions.DrawsAfterEndLocation);
			context.RestoreState ();


			//// Off-Leds
			{
				//// Bezier 2 Drawing
				UIBezierPath bezier2Path = new UIBezierPath ();
				bezier2Path.MoveTo (new PointF (217.4f, 440.9f));
				bezier2Path.AddLineTo (new PointF (45.67f, 440.9f));
				bezier2Path.AddCurveToPoint (new PointF (19.91f, 412.28f), new PointF (30.79f, 437.09f), new PointF (22.2f, 427.55f));
				bezier2Path.AddLineTo (new PointF (67.43f, 395.11f));
				bezier2Path.AddLineTo (new PointF (204.81f, 395.11f));
				bezier2Path.AddLineTo (new PointF (217.4f, 440.9f));
				bezier2Path.ClosePath ();
				bezier2Path.MiterLimit = 4;

				color4.SetFill ();
				bezier2Path.Fill ();


				//// Bezier 3 Drawing
				UIBezierPath bezier3Path = new UIBezierPath ();
				bezier3Path.MoveTo (new PointF (21.06f, 400.83f));
				bezier3Path.AddLineTo (new PointF (35.94f, 252));
				bezier3Path.AddLineTo (new PointF (48.54f, 240.55f));
				bezier3Path.AddLineTo (new PointF (79.44f, 274.9f));
				bezier3Path.AddLineTo (new PointF (68.57f, 383.66f));
				bezier3Path.AddLineTo (new PointF (21.06f, 400.83f));
				bezier3Path.ClosePath ();
				bezier3Path.MiterLimit = 4;

				color4.SetFill ();
				bezier3Path.Fill ();


				//// Bezier 4 Drawing
				UIBezierPath bezier4Path = new UIBezierPath ();
				bezier4Path.MoveTo (new PointF (98.34f, 86));
				bezier4Path.AddLineTo (new PointF (87.46f, 194.76f));
				bezier4Path.AddLineTo (new PointF (49.68f, 229.1f));
				bezier4Path.AddLineTo (new PointF (39.38f, 217.65f));
				bezier4Path.AddLineTo (new PointF (54.26f, 68.82f));
				bezier4Path.AddLineTo (new PointF (98.34f, 86));
				bezier4Path.ClosePath ();
				bezier4Path.MiterLimit = 4;

				color4.SetFill ();
				bezier4Path.Fill ();


				//// Bezier 5 Drawing
				UIBezierPath bezier5Path = new UIBezierPath ();
				bezier5Path.MoveTo (new PointF (236.86f, 74.55f));
				bezier5Path.AddLineTo (new PointF (100.05f, 74.55f));
				bezier5Path.AddLineTo (new PointF (55.98f, 57.38f));
				bezier5Path.AddCurveToPoint (new PointF (87.46f, 28.75f), new PointF (61.32f, 42.12f), new PointF (71.81f, 32.57f));
				bezier5Path.AddLineTo (new PointF (258.62f, 28.75f));
				bezier5Path.AddLineTo (new PointF (236.86f, 74.55f));
				bezier5Path.ClosePath ();
				bezier5Path.MiterLimit = 4;

				color4.SetFill ();
				bezier5Path.Fill ();


				//// Bezier 6 Drawing
				UIBezierPath bezier6Path = new UIBezierPath ();
				bezier6Path.MoveTo (new PointF (234.58f, 211.93f));
				bezier6Path.AddLineTo (new PointF (255.18f, 234.83f));
				bezier6Path.AddLineTo (new PointF (230, 257.73f));
				bezier6Path.AddLineTo (new PointF (81.16f, 257.73f));
				bezier6Path.AddLineTo (new PointF (60.56f, 234.83f));
				bezier6Path.AddLineTo (new PointF (85.74f, 211.93f));
				bezier6Path.AddLineTo (new PointF (234.58f, 211.93f));
				bezier6Path.ClosePath ();
				bezier6Path.MiterLimit = 4;

				color4.SetFill ();
				bezier6Path.Fill ();


				//// Bezier 7 Drawing
				UIBezierPath bezier7Path = new UIBezierPath ();
				bezier7Path.MoveTo (new PointF (264.6f, 240.55f));
				bezier7Path.AddLineTo (new PointF (274.91f, 252));
				bezier7Path.AddLineTo (new PointF (258.88f, 412.28f));
				bezier7Path.AddCurveToPoint (new PointF (227.4f, 440.9f), new PointF (253.53f, 427.55f), new PointF (243.04f, 437.09f));
				bezier7Path.AddLineTo (new PointF (214.8f, 395.11f));
				bezier7Path.AddLineTo (new PointF (226.82f, 274.9f));
				bezier7Path.AddLineTo (new PointF (264.6f, 240.55f));
				bezier7Path.ClosePath ();
				bezier7Path.MiterLimit = 4;

				color4.SetFill ();
				bezier7Path.Fill ();


				//// Bezier 8 Drawing
				UIBezierPath bezier8Path = new UIBezierPath ();
				bezier8Path.MoveTo (new PointF (234.83f, 194.76f));
				bezier8Path.AddLineTo (new PointF (246.85f, 74.55f));
				bezier8Path.AddLineTo (new PointF (268.61f, 28.75f));
				bezier8Path.AddCurveToPoint (new PointF (294.37f, 57.38f), new PointF (283.49f, 32.58f), new PointF (292.08f, 42.12f));
				bezier8Path.AddLineTo (new PointF (278.34f, 217.66f));
				bezier8Path.AddLineTo (new PointF (265.75f, 229.1f));
				bezier8Path.AddLineTo (new PointF (234.83f, 194.76f));
				bezier8Path.ClosePath ();
				bezier8Path.MiterLimit = 4;

				color4.SetFill ();
				bezier8Path.Fill ();


				//// Bezier 16 Drawing
				UIBezierPath bezier16Path = new UIBezierPath ();
				bezier16Path.MoveTo (new PointF (316.27f, 454.9f));
				bezier16Path.AddLineTo (new PointF (270.47f, 454.9f));
				bezier16Path.AddLineTo (new PointF (275.05f, 409.11f));
				bezier16Path.AddLineTo (new PointF (320.84f, 409.11f));
				bezier16Path.AddLineTo (new PointF (316.27f, 454.9f));
				bezier16Path.ClosePath ();
				bezier16Path.MiterLimit = 4;

				color12.SetFill ();
				bezier16Path.Fill ();
			}


			//// dp_on Drawing
			UIBezierPath dp_onPath = new UIBezierPath ();
			dp_onPath.MoveTo (new PointF (316.27f, 454.9f));
			dp_onPath.AddLineTo (new PointF (270.47f, 454.9f));
			dp_onPath.AddLineTo (new PointF (275.05f, 409.11f));
			dp_onPath.AddLineTo (new PointF (320.84f, 409.11f));
			dp_onPath.AddLineTo (new PointF (316.27f, 454.9f));
			dp_onPath.ClosePath ();
			dp_onPath.MiterLimit = 4;

			color13.SetFill ();
			dp_onPath.Fill ();


			//// g_on Drawing
// 			UIBezierPath g_onPath = new UIBezierPath ();
// 			g_onPath.MoveTo (new PointF (234.58f, 211.93f));
// 			g_onPath.AddLineTo (new PointF (255.18f, 234.83f));
// 			g_onPath.AddLineTo (new PointF (230, 257.73f));
// 			g_onPath.AddLineTo (new PointF (81.16f, 257.73f));
// 			g_onPath.AddLineTo (new PointF (60.56f, 234.83f));
// 			g_onPath.AddLineTo (new PointF (85.74f, 211.93f));
// 			g_onPath.AddLineTo (new PointF (234.58f, 211.93f));
// 			g_onPath.ClosePath ();
// 			g_onPath.MiterLimit = 4;
// 
// 			context.SaveState ();
// 			g_onPath.AddClip ();
// 			context.DrawLinearGradient (linearGradient4854,
// 			    new PointF (60.56f, 234.83f),
// 			    new PointF (255.18f, 234.83f),
// 			    CGGradientDrawingOptions.DrawsBeforeStartLocation | CGGradientDrawingOptions.DrawsAfterEndLocation);
// 			context.RestoreState ();


			//// f_on Drawing
			UIBezierPath f_onPath = new UIBezierPath ();
			f_onPath.MoveTo (new PointF (98.33f, 86));
			f_onPath.AddLineTo (new PointF (87.46f, 194.76f));
			f_onPath.AddLineTo (new PointF (49.68f, 229.1f));
			f_onPath.AddLineTo (new PointF (39.38f, 217.65f));
			f_onPath.AddLineTo (new PointF (54.26f, 68.82f));
			f_onPath.AddLineTo (new PointF (98.33f, 86));
			f_onPath.ClosePath ();
			f_onPath.MiterLimit = 4;

			context.SaveState ();
			f_onPath.AddClip ();
			context.DrawLinearGradient (linearGradient4902,
			    new PointF (76.84f, 68.82f),
			    new PointF (68.86f, 229.1f),
			    CGGradientDrawingOptions.DrawsBeforeStartLocation | CGGradientDrawingOptions.DrawsAfterEndLocation);
			context.RestoreState ();


			//// e_on Drawing
			UIBezierPath e_onPath = new UIBezierPath ();
			e_onPath.MoveTo (new PointF (21.06f, 400.83f));
			e_onPath.AddLineTo (new PointF (35.94f, 252));
			e_onPath.AddLineTo (new PointF (48.54f, 240.55f));
			e_onPath.AddLineTo (new PointF (79.44f, 274.9f));
			e_onPath.AddLineTo (new PointF (68.57f, 383.66f));
			e_onPath.AddLineTo (new PointF (21.06f, 400.83f));
			e_onPath.ClosePath ();
			e_onPath.MiterLimit = 4;

			context.SaveState ();
			e_onPath.AddClip ();
			context.DrawLinearGradient (linearGradient4894,
			    new PointF (50.25f, 240.55f),
			    new PointF (43.02f, 400.83f),
			    CGGradientDrawingOptions.DrawsBeforeStartLocation | CGGradientDrawingOptions.DrawsAfterEndLocation);
			context.RestoreState ();


			//// c_on Drawing
			UIBezierPath c_onPath = new UIBezierPath ();
			c_onPath.MoveTo (new PointF (264.6f, 240.55f));
			c_onPath.AddLineTo (new PointF (274.91f, 252));
			c_onPath.AddLineTo (new PointF (258.88f, 412.28f));
			c_onPath.AddCurveToPoint (new PointF (227.4f, 440.9f), new PointF (253.53f, 427.55f), new PointF (243.04f, 437.09f));
			c_onPath.AddLineTo (new PointF (214.8f, 395.11f));
			c_onPath.AddLineTo (new PointF (226.82f, 274.9f));
			c_onPath.AddLineTo (new PointF (264.6f, 240.55f));
			c_onPath.ClosePath ();
			c_onPath.MiterLimit = 4;

			context.SaveState ();
			c_onPath.AddClip ();
			context.DrawLinearGradient (linearGradient4870,
			    new PointF (252.26f, 240.55f),
			    new PointF (244.86f, 440.9f),
			    CGGradientDrawingOptions.DrawsBeforeStartLocation | CGGradientDrawingOptions.DrawsAfterEndLocation);
			context.RestoreState ();


			//// d_on Drawing
			UIBezierPath d_onPath = new UIBezierPath ();
			d_onPath.MoveTo (new PointF (217.4f, 440.9f));
			d_onPath.AddLineTo (new PointF (45.67f, 440.9f));
			d_onPath.AddCurveToPoint (new PointF (19.91f, 412.28f), new PointF (30.79f, 437.09f), new PointF (22.2f, 427.55f));
			d_onPath.AddLineTo (new PointF (67.42f, 395.11f));
			d_onPath.AddLineTo (new PointF (204.81f, 395.11f));
			d_onPath.AddLineTo (new PointF (217.4f, 440.9f));
			d_onPath.ClosePath ();
			d_onPath.MiterLimit = 4;

			context.SaveState ();
			d_onPath.AddClip ();
			context.DrawLinearGradient (linearGradient4886,
			    new PointF (19.91f, 418.01f),
			    new PointF (217.4f, 418.01f),
			    CGGradientDrawingOptions.DrawsBeforeStartLocation | CGGradientDrawingOptions.DrawsAfterEndLocation);
			context.RestoreState ();


			//// b_on Drawing
			UIBezierPath b_onPath = new UIBezierPath ();
			b_onPath.MoveTo (new PointF (234.83f, 194.76f));
			b_onPath.AddLineTo (new PointF (246.85f, 74.55f));
			b_onPath.AddLineTo (new PointF (268.61f, 28.75f));
			b_onPath.AddCurveToPoint (new PointF (294.37f, 57.38f), new PointF (283.49f, 32.57f), new PointF (292.08f, 42.12f));
			b_onPath.AddLineTo (new PointF (278.34f, 217.66f));
			b_onPath.AddLineTo (new PointF (265.75f, 229.1f));
			b_onPath.AddLineTo (new PointF (234.83f, 194.76f));
			b_onPath.ClosePath ();
			b_onPath.MiterLimit = 4;

			b_onPath.UsesEvenOddFillRule = true;

			context.SaveState ();
			b_onPath.AddClip ();
			context.DrawLinearGradient (linearGradient4840,
			    new PointF (270.84f, 28.75f),
			    new PointF (254.83f, 212.17f),
			    CGGradientDrawingOptions.DrawsBeforeStartLocation | CGGradientDrawingOptions.DrawsAfterEndLocation);
			context.RestoreState ();


			//// a_on Drawing
			UIBezierPath a_onPath = new UIBezierPath ();
			a_onPath.MoveTo (new PointF (236.86f, 74.55f));
			a_onPath.AddLineTo (new PointF (100.05f, 74.55f));
			a_onPath.AddLineTo (new PointF (55.98f, 57.38f));
			a_onPath.AddCurveToPoint (new PointF (87.46f, 28.75f), new PointF (61.32f, 42.12f), new PointF (71.81f, 32.57f));
			a_onPath.AddLineTo (new PointF (258.62f, 28.75f));
			a_onPath.AddLineTo (new PointF (236.86f, 74.55f));
			a_onPath.ClosePath ();
			a_onPath.MiterLimit = 4;

			context.SaveState ();
			a_onPath.AddClip ();
			context.DrawLinearGradient (linearGradient4910,
			    new PointF (55.98f, 51.65f),
			    new PointF (258.62f, 51.65f),
			    CGGradientDrawingOptions.DrawsBeforeStartLocation | CGGradientDrawingOptions.DrawsAfterEndLocation);
			context.RestoreState ();


			//// On-Dot
			{
			}


			//// Rectangle Drawing
			var rectanglePath = UIBezierPath.FromRect (new RectangleF (357, 25, 0, 0));
			context.SaveState ();
			rectanglePath.AddClip ();
			context.DrawLinearGradient (background_1_,
			    new PointF (357, 265.96f),
			    new PointF (357, -213.21f),
			    CGGradientDrawingOptions.DrawsBeforeStartLocation | CGGradientDrawingOptions.DrawsAfterEndLocation);
			context.RestoreState ();


			//// Rounded Rectangle Drawing
			var roundedRectanglePath = UIBezierPath.FromRoundedRect (new RectangleF (32.5f, 46.5f, 0, 0), 0);
			UIColor.White.SetFill ();
			roundedRectanglePath.Fill ();
			UIColor.Black.SetStroke ();
			roundedRectanglePath.LineWidth = 1;
			roundedRectanglePath.Stroke ();



		}
	}
}