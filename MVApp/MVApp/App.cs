using MVApp.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace MVApp
{
    public class App : Application
    {
        public App()
        {
            // The root page of your application
            //When we are working with navigation, we need to set the binding in another way.

            MainPage = new NavigationPage(new BooksView());
                //new BooksView();
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
