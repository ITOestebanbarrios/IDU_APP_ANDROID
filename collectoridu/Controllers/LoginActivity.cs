
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace collectoridu.Controllers
{
    /*[Activity(Label = "SplashActivity", MainLauncher = true, Icon = "@mipmap/icon")]
    public class SplashActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            this.ActionBar.Hide();
            SetContentView(Resource.Layout.Splash);


            // Create your application here
        }
    }*/

    [Activity(Label = "Login Screen App", MainLauncher = true, Theme = "@style/Theme.Splash", NoHistory=true, Icon = "@mipmap/icon")]
    public class LoginActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

			SetContentView(Resource.Layout.Login);
            //Display Splash Screen for 4 Sec  
            //Thread.Sleep(4000);
            //Start Activity1 Activity  
            //StartActivity(typeof(Activity1));
        }
    }
}
