using System;
using System.Drawing;
using System.Threading;
using Foundation;
using UIKit;

namespace ThreadXamarin.iOS
{
	public partial class ThreadXamarin_iOSViewController : UIViewController
	{
		int i=0;
		Thread first ;
		public ThreadXamarin_iOSViewController (IntPtr handle) : base (handle)
		{
			first= new Thread(new ThreadStart(mythread));
		}

		public override void DidReceiveMemoryWarning ()
		{
			// Releases the view if it doesn't have a superview.
			base.DidReceiveMemoryWarning ();
			
			// Release any cached data, images, etc that aren't in use.
		}

		#region View lifecycle

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			// Perform any additional setup after loading the view, typically from a nib.
		}

		public override void ViewWillAppear (bool animated)
		{
			base.ViewWillAppear (animated);
		}

		public override void ViewDidAppear (bool animated)
		{
			base.ViewDidAppear (animated);
		}

		public override void ViewWillDisappear (bool animated)
		{
			base.ViewWillDisappear (animated);
		}

		public override void ViewDidDisappear (bool animated)
		{
			base.ViewDidDisappear (animated);
		}
		public void mythread(){
			for (int j = 0; j < 1000; j++) {
				InvokeOnMainThread (delegate {  
					label.Text = "I=" + i;  
				});
				Thread.Sleep(1000);
				i++;
			}
		}

		partial void btn_start_TouchUpInside (UIButton sender)
		{
			first.Start ();
		}

		partial void btn_stop_TouchUpInside (UIButton sender)
		{
			first.Abort();
		}
		#endregion
	}
}

