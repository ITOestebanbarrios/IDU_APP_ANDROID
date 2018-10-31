
using Android.App;
using Android.OS;
using Android.Widget;

namespace collectoridu.Controllers
{
    [Activity(Label = "OlvidasteActivity")]
    public class OlvidasteActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.OlvidasteDatos);

            ActionBar.SetHomeButtonEnabled(true);
            ActionBar.SetDisplayHomeAsUpEnabled(true);
        }
    }



}
