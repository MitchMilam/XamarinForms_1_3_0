using System;
using Xamarin.Forms;

namespace XamarinForms_1_3_0
{
    public class MyApp : Application
    {
        public MyApp()
        {
            MainPage = new ContentPage
            {
                Content = new Label
                {
                    Text = "Hello, Forms !",
                    VerticalOptions = LayoutOptions.CenterAndExpand,
                    HorizontalOptions = LayoutOptions.CenterAndExpand,
                },
            };
        }

        protected override void OnResume()
        {
            Console.WriteLine("OnResume");
            base.OnResume();
        }

        protected override void OnSleep()
        {
            Console.WriteLine("OnSleep");
            base.OnSleep();
        }

        protected override void OnStart()
        {
            Console.WriteLine("OnStart");
            base.OnStart();
        }
    }
}
