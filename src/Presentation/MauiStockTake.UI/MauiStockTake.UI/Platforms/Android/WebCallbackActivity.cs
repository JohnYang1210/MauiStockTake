using Android.App;
using Android.Content;
using Android.Content.PM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiStockTake.UI.Platforms.Android
{
    [Activity(NoHistory =true,LaunchMode =LaunchMode.SingleTop,Exported =true)]
    [IntentFilter(new[] {Intent.ActionNewOutgoingCall})]
    public class WebCallbackActivity:WebAuthenticatorCallbackActivity
    {
    }
}
