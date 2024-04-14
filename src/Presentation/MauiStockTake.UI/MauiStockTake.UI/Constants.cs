using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiStockTake.UI
{
    public static class Constants
    {
        public const string BaseUrl = "https://4124-2409-8a62-2de-e040-1137-15f7-75f5-6102.ngrok-free.app";
        public const string RedirectUri = "auth.com.mildredsurf.stocktake://callback";
        public const string AuthorityUri = "https://4124-2409-8a62-2de-e040-1137-15f7-75f5-6102.ngrok-free.app";
        public const string ClientId = "com.mildredsurf.stocktake";
        //Attention!!!Should be WebAPIAPI here...
        public const string Scope = "openid profile offline_access MauiStockTake.WebAPIAPI";

    }
}
