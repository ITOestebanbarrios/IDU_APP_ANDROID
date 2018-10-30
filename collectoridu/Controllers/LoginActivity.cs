
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
using Android.Util;
//using System.Diagnostics;

namespace collectoridu.Controllers
{

    [Activity(Label = "Login Screen App", MainLauncher = true, Theme = "@style/Theme.Splash", NoHistory=true, Icon = "@mipmap/icon")]
    public class LoginActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
			SetContentView(Resource.Layout.Login);


            Button button = FindViewById<Button>(Resource.Id.login_iniciar);
            TextView olvidasteUsuario = FindViewById<TextView>(Resource.Id.olvidaste_usuario);
            TextView olvidasteContrasena = FindViewById<TextView>(Resource.Id.olvidaste_contrasena);

            button.Click += delegate {
                Log.Warn("YES", "ok_ok_ok_ok_ok_ok_ok_ok");
            };

            olvidasteUsuario.Click += delegate {
                StartActivity(typeof(OlvidasteActivity));
            };

            olvidasteContrasena.Click += delegate {
                StartActivity(typeof(OlvidasteActivity));
            };



            //Display Splash Screen for 4 Sec  
            //Thread.Sleep(4000);
            //Start Activity1 Activity  
            //StartActivity(typeof(Activity1));
        }
    }
}
