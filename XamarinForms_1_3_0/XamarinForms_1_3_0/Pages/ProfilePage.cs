using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace XamarinForms_1_3_0
{
    public class ProfilePage : ContentPage
    {
        public UserProfile Profile;

        public ProfilePage(Application app)
        {
            var nameEntry = new Entry
            {
                Placeholder = "Your name",
                VerticalOptions = LayoutOptions.Start,
            };

            var emailEntry = new Entry
            {
                Placeholder = "Email address",
                VerticalOptions = LayoutOptions.Start,
            };
            
            var passwordEntry = new Entry
            {
                Placeholder = "password",
                VerticalOptions = LayoutOptions.Start,
                IsPassword = true,
            };

            var saveButton = new Button
            {
                Text = " Save ",
            };

            nameEntry.SetBinding(Entry.TextProperty, new Binding("Name", BindingMode.TwoWay));
            emailEntry.SetBinding(Entry.TextProperty, new Binding("Email", BindingMode.TwoWay));
            passwordEntry.SetBinding(Entry.TextProperty, new Binding("Password", BindingMode.TwoWay));

            saveButton.Clicked += OnSaveButtonClicked;

            var stack = new StackLayout
            {
                Orientation = StackOrientation.Vertical,
                VerticalOptions = LayoutOptions.FillAndExpand,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                Children =
                {
                    nameEntry,
                    emailEntry,
                    passwordEntry,
                    saveButton
                }
            };

            Padding = new Thickness(10, Device.OnPlatform(20, 0, 0), 10, 5);
            Content = stack;
        }

        void OnSaveButtonClicked(object sender, EventArgs e)
        {
            //SetProfile();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            Console.WriteLine("Properties: {0}", Application.Current.Properties.Count);
        }
    }
}
