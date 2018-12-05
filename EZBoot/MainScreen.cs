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
        private void deviceSpinner_ItemSelected(object sender, AdapterView.ItemSelectedEventArgs e)
        {
            Spinner spinner = (Spinner)sender;
            if (spinner.GetItemAtPosition(e.Position).ToString() != "Select Device")
            {
                string selectionToast = string.Format("You have selected {0}", spinner.GetItemAtPosition(e.Position));
                Toast.MakeText(this, selectionToast, ToastLength.Long).Show();
            }        
        }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            //Initialize, set layout and initialize elements
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.MainPage);
            Button executeButton = FindViewById<Button>(Resource.Id.executeButton);
            Button configureButton = FindViewById<Button>(Resource.Id.configureButton);
            Spinner deviceSpinner = FindViewById<Spinner>(Resource.Id.deviceSpinner);

            deviceSpinner.ItemSelected += new EventHandler<AdapterView.ItemSelectedEventArgs>(deviceSpinner_ItemSelected);
            var spinnerAdapter = ArrayAdapter.CreateFromResource(
                    this, Resource.Array.devices_array, Android.Resource.Layout.SimpleSpinnerItem);

            spinnerAdapter.SetDropDownViewResource(Android.Resource.Layout.SimpleSpinnerDropDownItem);
            deviceSpinner.Adapter = spinnerAdapter;
            // Create your application here

        }
    }
}