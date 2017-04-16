using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using UIKit;

namespace MyStuff.iOS
{
	[Register("AppDelegate")]
	public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
	{
		public override bool FinishedLaunching(UIApplication app, NSDictionary options)
		{
			global::Xamarin.Forms.Forms.Init();

			// Code for starting up the Xamarin Test Cloud Agent
#if ENABLE_TEST_CLOUD
			Xamarin.Calabash.Start();
#endif

			LoadApplication(new App());
#pragma warning disable CS0219
			//var x = typeof(Xamarin.Forms.Themes.DarkThemeResources);
			var x = typeof(Xamarin.Forms.Themes.LightThemeResources);
			x = typeof(Xamarin.Forms.Themes.iOS.UnderlineEffect);
#pragma warning restore CS0219
			return base.FinishedLaunching(app, options);
		}
	}
}
