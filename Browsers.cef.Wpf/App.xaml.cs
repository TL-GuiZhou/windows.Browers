using CefSharp;
using CefSharp.Wpf;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Browsers.cef.Wpf
{
    /// <summary>
    /// App.xaml 的交互逻辑
    /// </summary>
    public partial class App : Application
    {

        public App()
        {
            var settings = new CefSettings()
            {
                CachePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "CefSharp\\Cache")
            };

            settings.CefCommandLineArgs.Add("ppapi-flash-path", @"pepflashplayer.dll");
            settings.CefCommandLineArgs.Add("enable-media-stream", "1");
            Cef.EnableHighDPISupport();
            Cef.Initialize(settings, performDependencyCheck: true, browserProcessHandler: null);

        }

    }
}
