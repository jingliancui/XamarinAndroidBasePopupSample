using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Widget;
using AndroidX.AppCompat.App;

namespace SampleApp
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        private PopupTipWindow popupTipWindow;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            popupTipWindow = new PopupTipWindow(this);
            popupTipWindow.SetOutSideTouchable(true);
            popupTipWindow.SetBackgroundColor(Android.Graphics.Color.Transparent);

            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            var btn2 = FindViewById<Button>(Resource.Id.mybtn2);
            btn2.Click += (s, e) =>
            {                
                popupTipWindow.ShowPopupWindow(btn2);
            };

            var btn = FindViewById<Button>(Resource.Id.mybtn);
            btn.Click += (s, e) => 
            {
                popupTipWindow.ShowPopupWindow(btn);
            };
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}