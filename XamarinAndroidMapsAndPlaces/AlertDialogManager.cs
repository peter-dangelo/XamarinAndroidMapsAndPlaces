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

namespace XamarinAndroidSandbox
{
    public static class AlertDialogManager
    {
        public static void ShowAlertDialog(Context context, string title, string message,
                                    Boolean isSuccessStatus)
        {
            var alertDialog = new AlertDialog.Builder(context).Create();

            // Setting Dialog Title
            alertDialog.SetTitle(title);

            // Setting Dialog Message
            alertDialog.SetMessage(message);

            // Setting alert dialog icon
            alertDialog.SetIcon(isSuccessStatus ? Resource.Drawable.success : Resource.Drawable.fail);

            // Setting OK Button
            alertDialog.SetButton("OK", (sender, args) => { });

            // Showing Alert Message
            alertDialog.Show();
        }
    }
}