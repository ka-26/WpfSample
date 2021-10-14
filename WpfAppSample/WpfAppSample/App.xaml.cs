using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using Microsoft.Extensions.DependencyInjection;

namespace WpfAppSample
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static Frame RootFrame;

        public App()
        {
            var services = new ServiceCollection();
            services.AddSingleton<Views.Page1>();
            services.AddSingleton<Views.Page2>();

            // インスタンスを提供してくれる人を作る
            using var provider = services.BuildServiceProvider();

        }
    }
}
