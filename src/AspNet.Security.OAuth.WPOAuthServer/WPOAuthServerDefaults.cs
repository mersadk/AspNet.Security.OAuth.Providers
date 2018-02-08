using System;
using System.Collections.Generic;
using System.Text;

namespace AspNet.Security.OAuth.WPOAuthServer
{
    public class WPOAuthServerDefaults
    {
        /// <summary>
        /// Default value for <see cref="AuthenticationScheme.Name"/>.
        /// </summary>
        public const string AuthenticationScheme = "WPOAuthServer";

        /// <summary>
        /// Default value for <see cref="AuthenticationScheme.DisplayName"/>.
        /// </summary>
        public const string DisplayName = "WP OAuth Server";

        /// <summary>
        /// Default value for <see cref="AuthenticationSchemeOptions.ClaimsIssuer"/>.
        /// </summary>
        public const string Issuer = "WPOAuthServer";
    }
}
