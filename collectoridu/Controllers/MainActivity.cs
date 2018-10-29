using Android.App;
using Android.Widget;
using Android.OS;
using Android.Gms.Maps;


namespace collectoridu
{
    [Activity(Label = "MainActivity")]
    public class MainActivity : Activity, IOnMapReadyCallback
    {
        //int count = 1;

        private GoogleMap GMap;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            /*Button button = FindViewById<Button>(Resource.Id.myButton);
            button.Click += delegate { 
                button.Text = $"{count++} clicks!"; 
            };*/
            SetUpMap();
        }

        private void SetUpMap()
        {
            if (GMap == null)
            {
                FragmentManager.FindFragmentById<MapFragment>(Resource.Id.googlemap).GetMapAsync(this);
            }
        }

        public void OnMapReady(GoogleMap googleMap)
        {
            this.GMap = googleMap;
        }
    }
}

