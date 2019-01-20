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

namespace EZBoot
{
    [Activity(Label = "Config Screen")]
    public class ConfigScreen : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            EditText configMACAddress = FindViewById<EditText>(Resource.Id.configMACAddress);
            EditText configIPAddress = FindViewById<EditText>(Resource.Id.configIPAddress);
            EditText configPort = FindViewById<EditText>(Resource.Id.configPort);
            Button saveConfig = FindViewById<Button>(Resource.Id.saveConfig);
            Button cancelConfig = FindViewById<Button>(Resource.Id.cancelConfig);


            saveConfig.Click += (o,e) => {

            };

            cancelConfig.Click += (o, e) =>
            {
                Intent returnToMenu = new Intent(this, typeof(MainActivity));
            };
            
            // Create your application here
        }
    }
}