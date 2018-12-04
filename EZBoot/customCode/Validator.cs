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
    class Validator
    {
        private string loginUser { get; set; }
        private string loginPassword { get; set; }

        public Validator(string userName,string userPassword)
        {
            loginUser = userName;
            loginPassword = userPassword;
        }

        public bool validateUser() //TODO database lookup
        {
           if(loginUser == "tomasz" && loginPassword == "123")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}