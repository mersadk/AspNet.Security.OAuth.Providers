using AspNet.Security.OAuth.WPOAuthServer;
using JetBrains.Annotations;
using Microsoft.AspNetCore.Authentication;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class WPOAuthServerAuthenticationExtensions
    {
        /// <summary>
        /// Adds <see cref="WordPressAuthenticationHandler"/> to the specified
        /// <see cref="AuthenticationBuilder"/>, which enables WordPress authentication capabilities.
        /// </summary>
        /// <param name="builder">The authentication builder.</param>
        /// <param name="configuration">The delegate used to configure the OpenID 2.0 options.</param>
        /// <returns>A reference to this instance after the operation has completed.</returns>
        public static AuthenticationBuilder AddWPOAuthServer(
            [NotNull] this AuthenticationBuilder builder,
            [NotNull] Action<WPOAuthServerAuthenticationOptions> configuration)
        {
            return builder.AddOAuth<WPOAuthServerAuthenticationOptions, WPOAuthServerAuthenticationHandler>(WPOAuthServerDefaults.AuthenticationScheme, WPOAuthServerDefaults.DisplayName, configuration);
        }
    }
}
