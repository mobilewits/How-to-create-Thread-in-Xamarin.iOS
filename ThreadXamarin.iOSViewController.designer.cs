// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace ThreadXamarin.iOS
{
	[Register ("ThreadXamarin_iOSViewController")]
	partial class ThreadXamarin_iOSViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton btn_start { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton btn_stop { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel label { get; set; }

		[Action ("btn_start_TouchUpInside:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void btn_start_TouchUpInside (UIButton sender);

		[Action ("btn_stop_TouchUpInside:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void btn_stop_TouchUpInside (UIButton sender);

		void ReleaseDesignerOutlets ()
		{
			if (btn_start != null) {
				btn_start.Dispose ();
				btn_start = null;
			}
			if (btn_stop != null) {
				btn_stop.Dispose ();
				btn_stop = null;
			}
			if (label != null) {
				label.Dispose ();
				label = null;
			}
		}
	}
}
