using Facebook.AspNetCore.Client.Models;
using Facebook.NetCore.Client;
using Facebook.NetCore.Service;
using Facebook.NetCore.Service.Services.PageService;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Facebook.AspNetCore.Client.ExtensionMethods
{
    public static class IServiceCollectionExtensionMethod
    {
        public static IServiceCollection AddFacebookClient(this IServiceCollection services, FacebookClientOptions options)
        {
            if(string.IsNullOrWhiteSpace(options.ClientId)) { throw new ArgumentNullException(nameof(options.ClientId)); }
            if(string.IsNullOrWhiteSpace(options.ClientSecret)) { throw new ArgumentNullException(nameof(options.ClientSecret)); }

            services.AddSingleton<IFacebookHttpClient, FacebookHttpClient>(factory =>
            {
                return new FacebookHttpClient(version: "v6.0", accept: "application/json");
            });

            services.AddSingleton<IFacebookService, FacebookService>(factory =>
            {
                return new FacebookService(options.ClientId, options.ClientSecret);
            });

            services.AddTransient<IPageService, PageService>();

            return services;
        }
    }
}
