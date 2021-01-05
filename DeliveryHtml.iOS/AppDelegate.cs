using System;
using Foundation;
using LabelHtml.Forms.Plugin.iOS;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

namespace DeliveryHtml.iOS
{
	[Register("AppDelegate")]
	public partial class AppDelegate : FormsApplicationDelegate
	{
		public override bool FinishedLaunching(UIApplication app, NSDictionary options)
		{
			HtmlLabelRenderer.Initialize();
			Forms.Init();
			LoadApplication(new App());

			return base.FinishedLaunching(app, options);
		}
	}
}
