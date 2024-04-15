using IdentityModel.OidcClient;
using MauiStockTake.Client.Authentication;

//using Java.Nio.Channels;
using MauiStockTake.UI.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IBrowser = IdentityModel.OidcClient.Browser.IBrowser;
namespace MauiStockTake.UI.Services
{
    public class AuthService : IAuthService
    {
        private readonly OidcClientOptions _options;
        public AuthService(IBrowser browser)
        {
            _options = new OidcClientOptions
            {
                Authority=Constants.AuthorityUri,
                ClientId=Constants.ClientId,
                Scope=Constants.Scope,
                RedirectUri=Constants.RedirectUri,
                Browser=browser
            };
        }
        async Task<bool> IAuthService.LoginAsync()
        {
            var oidClient = new OidcClient(_options);
            LoginResult loginResult = await oidClient.LoginAsync(new LoginRequest());
            if (loginResult.IsError)
            {
                //TODO:inspect and handle error
                return false;
            }
            AuthHandler.AuthToken = loginResult.AccessToken;
            return true;
        }
    }
}
