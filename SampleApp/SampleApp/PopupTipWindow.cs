using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Razerdp.Basepopup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SampleApp
{
    public class PopupTipWindow : BasePopupWindow
    {
        public PopupTipWindow(Android.Content.Context context) : base(context)
        {
            SetContentView(Resource.Layout.PopTipWindowsLayout);
        }
    }
}