using Android.App;
using Android.OS;
using Android.Widget;
using Android.Content;
using Android.Support.V7.App;
using Android.Runtime;



namespace EZBoot
{
    [Activity(Label = "EZBoot", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.MainPage);
            Button executeButton = FindViewById<Button>(Resource.Id.executeButton);
            Button configureButton = FindViewById<Button>(Resource.Id.configureButton);


            //Button click function for execute button

            executeButton.Click += (o, e) => {
                string macAddress;
                WakeOnLAN WOL = new WakeOnLAN();
                Toast.MakeText(this, WOL.Wakeup(macAddress), ToastLength.Long).Show();
            };

            //Button click function for config button
            configureButton.Click += (o, e) =>
            {
                Intent transferPages = new Intent(this, typeof(ConfigScreen));
                this.StartActivity(transferPages);
            };
        }
    }
}