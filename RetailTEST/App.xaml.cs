using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Microsoft.HockeyApp;

namespace RetailTEST
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
        }
        protected override async void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            Microsoft.HockeyApp.HockeyClient.Current.Configure("3aa050ba097647959aff5484808fa83d");
           

            Microsoft.HockeyApp.HockeyClient.Current.Configure("Your_App_ID").SetExceptionDescriptionLoader((Exception ex) =>
      {
          return "Exception HResult: " + ex.HResult.ToString();
      });
            await HockeyClient.Current.SendCrashesAsync(true);
        }
    }
}
