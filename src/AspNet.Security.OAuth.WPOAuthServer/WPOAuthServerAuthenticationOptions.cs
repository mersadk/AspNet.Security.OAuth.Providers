using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.OAuth;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Text;

namespace AspNet.Security.OAuth.WPOAuthServer
{
    public class WPOAuthServerAuthenticationOptions : OAuthOptions
    {
        private string _baseDomain;
        public string BaseDomain
        {
            set
            {
                _baseDomain = value;

                // Update endpoints
                AuthorizationEndpoint = $"{_baseDomain}oauth/authorize";
                TokenEndpoint = $"{_baseDomain}oauth/token";
                UserInformationEndpoint = $"{_baseDomain}oauth/me";
            }
        }

        public WPOAuthServerAuthenticationOptions()
        {
            ClaimsIssuer = WPOAuthServerDefaults.Issuer;
            CallbackPath = new PathString("/signin-wpoauthserver");

            ClaimActions.MapJsonKey(ClaimTypes.NameIdentifier, "ID");
            ClaimActions.MapJsonKey(ClaimTypes.Name, "display_name");
            ClaimActions.MapJsonKey(ClaimTypes.Email, "user_email");            
        }
    }
}
