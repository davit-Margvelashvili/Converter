using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Converter.Core.Abstractions;
using Converter.Data;
using Converter.WinForms.Forms;
using Microsoft.Extensions.DependencyInjection;

namespace Converter.WinForms
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var services = new ServiceCollection();
            ConfigureServices(services);

            using (var serviceProvider = services.BuildServiceProvider())
            {
                var mainForm = serviceProvider.GetRequiredService<MainForm>();

                ServiceContainer.Initializer(serviceProvider);

                Application.Run(mainForm);
            }
        }

        private static void ConfigureServices(ServiceCollection services) =>
            services.AddDbContext<ConverterContext>()
                .AddScoped<MainForm>()
                .AddScoped<ICategoryRepository, Repository>()
                .AddScoped<IUnitRepository, Repository>();
    }
}