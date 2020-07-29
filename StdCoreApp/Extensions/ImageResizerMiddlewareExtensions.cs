﻿using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using StdCoreApp.Middleware;

namespace StdCoreApp.Extensions
{
    public static class ImageResizerMiddlewareExtensions
    {
        public static IServiceCollection AddImageResizer(this IServiceCollection services)
        {
            return services.AddMemoryCache();
        }

        public static IApplicationBuilder UseImageResizer(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<ImageResizerMiddleware>();
        }
    }
}