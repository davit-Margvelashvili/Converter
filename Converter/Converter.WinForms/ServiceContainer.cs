using System;
using Microsoft.Extensions.DependencyInjection;

namespace Converter.WinForms
{
    internal static class ServiceContainer
    {
        private static IServiceProvider _serviceProvider;

        public static void Initializer(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public static T Get<T>() => _serviceProvider.GetRequiredService<T>();
    }
}