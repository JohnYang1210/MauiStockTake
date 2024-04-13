﻿using IdentityModel.OidcClient;
//using Java.Nio.Channels;
using MauiStockTake.UI.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiStockTake.UI.Services
{
    public class AuthService : IAuthService
    {
        private readonly OidcClientOptions _options;
        public AuthService()
        {
            _options = new OidcClientOptions
            {
                Authority=Constants.AuthorityUri,
                ClientId=Constants.ClientId,
                Scope=Constants.Scope,
                RedirectUri=Constants.RedirectUri,
                Browser=new AuthBrowser()
            };
        }
        async Task<bool> IAuthService.LoginAsync()
        {
            var oidClient = new OidcClient(_options);
            var loginResult = await oidClient.LoginAsync(new LoginRequest());
            if (loginResult.IsError)
            {
                //TODO:inspect and handle error
                return false;
            }
            return true;
        }
    }
}
