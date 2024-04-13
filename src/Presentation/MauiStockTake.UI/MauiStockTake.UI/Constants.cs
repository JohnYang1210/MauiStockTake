using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiStockTake.UI
{
    public static class Constants
    {
        public const string BaseUrl = "https://19e5-223-85-55-106.ngrok-free.app";
        public const string RedirectUri = "auth.com.mildredsurf.stocktake://callback";
        public const string AuthorityUri = "https://19e5-223-85-55-106.ngrok-free.app";
        public const string ClientId = "com.mildredsurf.stocktake";
        //Attention!!!Should be WebAPIAPI here...
        public const string Scope = "openid profile offline_access MauiStockTake.WebAPIAPI";
    }
}
