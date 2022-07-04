using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using WebApplication1.Settings.Services;

namespace WebApplication1
{
    public class RouteMiddleware : IMiddleware
    {
        private readonly IAppSettingsProvider _appSettingsProvider;

        public RouteMiddleware(IAppSettingsProvider appSettingsProvider)
        {
            _appSettingsProvider = appSettingsProvider;
        }

        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            //var subPathToAdd = _appSettingsProvider.Settings.AppSubPath;
            //Console.WriteLine("Before: " + context.Request.Path);

            //if (string.IsNullOrEmpty(subPathToAdd))
            //{
                await next.Invoke(context);
            //}

            //var splittedUrl = context.Request.Path.Value.Split("/");
            //var filtered = splittedUrl.Where(f => f != subPathToAdd);
            //var newUri = string.Join('/', filtered);

            //context.Request.Path = newUri;
            
            //Console.WriteLine("After: " + context.Request.Path);

            //await next.Invoke(context);
        }
    }
}