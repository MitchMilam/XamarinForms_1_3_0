using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace XamarinForms_1_3_0
{
    public class StylesDemoPage : ContentPage
    {
        public StylesDemoPage()
        {
            var stack = new StackLayout
            {
                Orientation = StackOrientation.Vertical,
                VerticalOptions = LayoutOptions.FillAndExpand,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                Children =
                {
                    new Label
                        {
                            Text = "BodyStyle",
                            Style = Device.Styles.BodyStyle
                        },
                    new Label
                        {
                            Text = "CaptionStyle",
                            Style = Device.Styles.CaptionStyle
                        },
                    new Label
                        {
                            Text = "ListItemTextStyle",
                            Style = Device.Styles.ListItemTextStyle
                        },
                    new Label
                        {
                            Text = "ListItemDetailTextStyle",
                            Style = Device.Styles.ListItemDetailTextStyle
                        },
                    new Label
                        {
                            Text = "SubtitleStyle",
                            Style = Device.Styles.SubtitleStyle
                        },
                    new Label
                        {
                            Text = "TitleStyle",
                            Style = Device.Styles.TitleStyle
                        },
                }
            };

            Padding = new Thickness(10, Device.OnPlatform(20, 0, 0), 10, 5);
            Content = stack;
        }
    }
}
