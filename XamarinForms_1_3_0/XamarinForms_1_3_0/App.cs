using System;
using Xamarin.Forms;

namespace XamarinForms_1_3_0
{
    public class MyApp : Application
    {
        public Label TimeLabel;
        public UserProfile Profile;

        public MyApp()
        {
            Properties["test1"] = "test";

            var label1 = new Label
            {
                Text = "Hello, Forms !",
                VerticalOptions = LayoutOptions.CenterAndExpand,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
            };

            TimeLabel = new Label
            {
                Text = "",
                VerticalOptions = LayoutOptions.CenterAndExpand,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
            };

            var stack = new StackLayout
            {
                Orientation = StackOrientation.Vertical,
                VerticalOptions = LayoutOptions.FillAndExpand,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                Children = { label1, TimeLabel }
            };

            //TimeLabel.BindingContext = Properties;
            //TimeLabel.SetBinding(Label.TextProperty, string.Format("[{0}]", "Time"));

            MainPage = new NavigationPage(new HomePage());  
          
            Console.WriteLine(Properties.ContainsKey("Time") ? "Time key found." : "Time key not found.");
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

        protected override void OnParentSet()
        {
            base.OnParentSet();
        }

        private UserProfile GetProfile()
        {
            if (!Properties.ContainsKey("UserProfile"))
            {
                Properties["UserProfile"] = new UserProfile();
            }

            return (UserProfile)Properties["UserProfile"];
        }

        private void SetProfile()
        {
            Properties["UserProfile"] = Profile;
        }
    }
}
