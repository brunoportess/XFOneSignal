using Com.OneSignal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace XFOneSignal
{
    public class App : Application
    {
        public App()
        {
            OneSignal.Current.StartInit("App_Id_do_OneSignal")
                  .EndInit();
            // The root page of your application
            MainPage = new ContentPage
            {
                Content = new StackLayout
                {
                    VerticalOptions = LayoutOptions.Center,
                    Children = {
                         new Label {
                             HorizontalTextAlignment = TextAlignment.Center,
                             Text = "Welcome to Xamarin Forms!"
                         }
                     }
                }
            };
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
