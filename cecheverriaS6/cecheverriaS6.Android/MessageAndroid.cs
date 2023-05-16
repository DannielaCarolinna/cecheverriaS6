﻿using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using cecheverriaS6.Droid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
[assembly: Xamarin.Forms.Dependency((typeof(MessageAndroid)))]
namespace cecheverriaS6.Droid
{
    public interface MessageAndroid : Message
    {
        public void LongAlert(string message)
        {
            Toast.MakeText(Application.Context, message, ToastLength.Long).Show();
        }

        public void ShortAlert (string message) 
        {
            Toast.MakeText(Application.Context, message, ToastLength.Short).Show();
        }
    }
}