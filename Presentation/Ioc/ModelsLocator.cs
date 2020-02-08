using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace Presentation.Ioc
{
    public class ModelsLocator
    {
        public MainWindowViewModel MainWindowViewModel => App.ServiceProvider.GetService<MainWindowViewModel>();
    }
}
