using Android.App;
using Android.Widget;
using Android.OS;

namespace BanditManchot
{
    [Activity(Label = "BanditManchot", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
        }
    }
}

