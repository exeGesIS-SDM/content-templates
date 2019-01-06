using cloudscribe.SimpleContent.Models;
using esdm.ContentTemplates.Services;
using Microsoft.Extensions.Configuration;
using System;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class StartupExtensions
    {
        public static IServiceCollection AddEsdmContentTemplatesForSimpleContent(
           this IServiceCollection services,
           IConfiguration configuration
           )
        {
            services.AddSingleton<IContentTemplateProvider, ContentTemplateProvider>();


            return services;
        }

    }
}
