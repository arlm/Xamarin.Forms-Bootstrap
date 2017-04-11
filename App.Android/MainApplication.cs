using System;
using Android.App;
using Android.Runtime;

namespace App.Droid
{
	[Application(
#if DEBUG
		Debuggable = true,
#else
		Debuggable = false,
#endif
		Name = "Android App",
		Label = "Android App",
		Description = "Android App description",
		Icon = "@drawable/icon",
		RoundIcon = "@drawable/icon",
		Logo = "@drawable/icon",
		Theme = "@style/MainTheme"
	)]
	public class MainApplication : Application
	{
		public MainApplication(IntPtr javaReference, JniHandleOwnership transfer) 
			: base(javaReference, transfer)
		{
			
		}

		public override void OnCreate()
		{
			base.OnCreate();
		}

		public override void OnTerminate()
		{
			base.OnTerminate();
		}

		public override void OnTrimMemory(Android.Content.TrimMemory level)
		{
			base.OnTrimMemory(level);
		}

		public override void OnLowMemory()
		{
			base.OnLowMemory();
		}
	}
}
