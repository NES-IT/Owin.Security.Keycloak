﻿using Nes.Owin.Security.Keycloak.Middleware;
using Owin;

namespace Nes.Owin.Security.Keycloak
{
    public static class AppBuilderExtension
    {
        public static IAppBuilder UseKeycloakAuthentication(this IAppBuilder app, KeycloakAuthenticationOptions options)
        {
            app.Use(typeof (KeycloakAuthenticationMiddleware), app, options);
            return app;
        }
    }
}