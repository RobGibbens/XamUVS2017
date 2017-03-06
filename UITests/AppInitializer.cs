using System;
using System.IO;
using System.Linq;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace XamU.UITests
{
	public class AppInitializer
	{
		public static IApp StartApp(Platform platform)
		{
            
			if (platform == Platform.Android)
			{
                var path = @"..\..\com.xamarin.xamu.apk";
				//return ConfigureApp.Android.StartApp();
                return ConfigureApp.Android
                    .ApkFile(path)
                    .StartApp();

            }

            return ConfigureApp.iOS.StartApp();
		}
	}
}
