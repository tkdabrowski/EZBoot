using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using System;
using Android.Content;

namespace EZBoot
{
    [Activity(Label = "EZBoot Login Screen", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {

            base.OnCreate(savedInstanceState);


            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.MainPage);

            //Initialize elements to make them functional
            Button executeButton = FindViewById<Button>(Resource.Id.executeButton);
            Button signUpButton = FindViewById<Button>(Resource.Id.signUpButton);
            EditText userName = FindViewById<EditText>(Resource.Id.userName);
            EditText userPassword = FindViewById<EditText>(Resource.Id.userPassword);


            //Button click function for login button
            loginButton.Click += (o, e) => {

            };

            //Button click function for sign up button
            configureButton.Click += (o, e) =>
            {
                Intent transferPages = new Intent(this, typeof(SignUpScreen));
            };
        }
    }
}