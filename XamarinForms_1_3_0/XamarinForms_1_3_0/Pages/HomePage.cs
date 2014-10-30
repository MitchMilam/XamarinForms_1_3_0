using System;
using System.Linq;
using System.Reflection;
using Xamarin.Forms;

namespace XamarinForms_1_3_0
{
    public class HomePage : ContentPage
    {
        public HomePage()
        {
            var navigateCommand = 
                new Command<Type>(async pageType =>
                {
                    var constructors = pageType.GetTypeInfo().DeclaredConstructors;

                    foreach (var page in from constructor in constructors
                                 where constructor.GetParameters().Length == 0 
                                 select (Page)constructor.Invoke(null))
                    {
                        await Navigation.PushAsync(page);
                        break;
                    }
                });

            Title = "Xamarin.Forms 1.3.0";
            Content = new TableView
            {
                Intent = TableIntent.Menu,
                Root = new TableRoot
                {
                    new TableSection("Samples")
                    {
                        new TextCell
                        {
                            Text = "ListView.ScrollTo",
                            Command = navigateCommand,
                            CommandParameter = typeof (ScrollToDemoPage)
                        },
                         new TextCell
                        {
                            Text = "Styles (Build-In)",
                            Command = navigateCommand,
                            CommandParameter = typeof (StylesDemoPage)
                        },
                    }
                }
            };
        }
    }
}
