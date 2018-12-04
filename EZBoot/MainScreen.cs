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
   
    [Activity(Label = "EZBoot Main Screen", Theme = "@style/AppTheme")]
    public class MainScreen : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            //Initialize, set layout and initialize elements
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.MainPage);
            Button executeButton = FindViewById<Button>(Resource.Id.executeButton);
            Button configureButton = FindViewById<Button>(Resource.Id.configureButton);
            Spinner deviceSpinner = FindViewById<Spinner>(Resource.Id.deviceSpinner);


            // Create your application here

        }
    }
}