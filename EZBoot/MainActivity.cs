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
            SetContentView(Resource.Layout.activity_main);

            //Initialize elements to make them functional
            Button loginButton = FindViewById<Button>(Resource.Id.loginButton);
            Button signUpButton = FindViewById<Button>(Resource.Id.signUpButton);
            EditText userName = FindViewById<EditText>(Resource.Id.userName);
            EditText userPassword = FindViewById<EditText>(Resource.Id.userPassword);


            //Button click function for login button
            loginButton.Click += (o, e) => {
                Validator validator = new Validator(userName.Text, userPassword.Text);
                bool validation;
                validation = validator.validateUser();

                if (validation == true)
                {
                    Toast.MakeText(this, "You have logged in", ToastLength.Long).Show();
                    Intent transferPages = new Intent(this, typeof(MainScreen));
                    this.StartActivity(transferPages);
                }
                else
                {
                    Toast.MakeText(this, "Login attempt failed, try again", ToastLength.Long).Show();
                }   
            };

            //Button click function for sign up button
            signUpButton.Click += (o, e) =>
            {
                Intent transferPages = new Intent(this, typeof(SignUpScreen));
            };
        }
    }
}