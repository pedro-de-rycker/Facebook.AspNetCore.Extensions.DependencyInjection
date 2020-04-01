using Facebook.AspNetCore.Client.Models;
using Facebook.NetCore.HttpClient;
using Facebook.NetCore.Service;
using Facebook.NetCore.Service.Services.PageService;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Net.Http.Headers;
using System.Text;

namespace Facebook.AspNetCore.Client.ExtensionMethods
{
    /// <summary>
    /// The IServiceCollection extension methods static class.
    /// </summary>
    /// 

    public static class IServiceCollectionExtensionMethod
    {
        /// <summary>
        /// Add the Facebook graph Api services.
        /// </summary>
        /// <param name="services">The IServiceCollection source.</param>
        /// <param name="options">The options passed.</param>
        /// <returns>Returns the IServiceCollection.</returns>
        /// 

        public static IServiceCollection AddFacebookServices([NotNull] this IServiceCollection services, [NotNull] FacebookServicesOptions options)
        {
            if(string.IsNullOrWhiteSpace(options.ClientId)) { throw new ArgumentNullException(nameof(options.ClientId)); }
            if(string.IsNullOrWhiteSpace(options.ClientSecret)) { throw new ArgumentNullException(nameof(options.ClientSecret)); }

            services.AddSingleton<FacebookHttpClient>(factory =>
            {
                FacebookHttpClient client = new FacebookHttpClient(version: "v6.0");
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                return client;
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
