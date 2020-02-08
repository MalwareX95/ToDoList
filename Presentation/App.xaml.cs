using Domain;
using Infrastructre;
using Microsoft.Extensions.DependencyInjection;
using Persistence;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Presentation
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static IServiceProvider ServiceProvider { get; private set; }
        protected override void OnStartup(StartupEventArgs e)
        {
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddDomain();
            serviceCollection.AddInfrastructre();
            serviceCollection.AddPersistence();
            ServiceProvider = serviceCollection.BuildServiceProvider();
            using (var scope = ServiceProvider.CreateScope())
            {
                scope.ServiceProvider.GetRequiredService<ApplicationDbContext>().Database.EnsureCreated();
            }
            base.OnStartup(e);
        }
    }
}
