using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiStockTake.UI
{
    public static class Constants
    {
        public const string BaseUrl = "https:xxxx";
        public const string RedirectUri = "auth.com.mildredsurf.stocktake://callback";
        public const string AuthorityUri = "https://xxx";
        public const string ClientId = "com.mildredsurf.stocktake";
        public const string Scope = "openid profile offline_access MauiStockTake.WebUIAPI";
    }
}
