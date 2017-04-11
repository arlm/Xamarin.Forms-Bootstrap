
using Android.App;
using Android.Content.PM;
using Android.OS;

using Xamarin.Forms;

namespace App.Droid
{
	[Activity (
		Label = "swagger_integration",
		Icon = "@drawable/icon", 
		Theme="@style/MainTheme",
		MainLauncher = true,
		ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation
	)]
	public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
	{
		protected override void OnCreate (Bundle savedInstanceState)
		{
			TabLayoutResource = Resource.Layout.Tabbar;
			ToolbarResource = Resource.Layout.Toolbar; 

			base.OnCreate (savedInstanceState);

			Forms.Init (this, savedInstanceState);
			LoadApplication (new Shared.Core.App ());
		}
	}
}

