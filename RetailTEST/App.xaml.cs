using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Microsoft.HockeyApp;
using System.IO;

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
        public static class Globals
        {
            public static String LOG_TEXT; // Modifiable
        }
/*
        protected override async void OnSessionEnding(SessionEndingCancelEventArgs e)
        {
            base.OnSessionEnding(e);
            

            await HockeyClient.Current.SendCrashesAsync(true);
        }
*/
        protected override async void OnStartup(StartupEventArgs e)
        {
           
            base.OnStartup(e);
            String file = "testLog.txt";
            Globals.LOG_TEXT = File.ReadAllText(file);
            String userName = "curtisTest", userContact = "curtish@itretail.com", appID = "3aa050ba097647959aff5484808fa83d";

            HockeyClient.Current.Configure(appID);
            HockeyClient.Current.UpdateContactInfo(userName, userContact);
            HockeyClient.Current.Configure(appID).SetExceptionDescriptionLoader((Exception ex) =>
      {
          return "Log Data: " + Globals.LOG_TEXT.ToString();
      });

            await HockeyClient.Current.SendCrashesAsync(true);
        }
    }
}
