using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace karusel
{
    public partial class MainPage : CarouselPage
    {
        public MainPage()
        {
            var redContentPage = new ContentPage
            {
                Content = new StackLayout
                {
                    Children =
                    {
                        new Label
                        {
                        Text = "Holerik",
                        FontSize = Device.GetNamedSize (NamedSize.Medium, typeof(Label)),                        
                        },
                        new Image {Source = "holerik.jpg"}

                    }
                }
            };
            var blueContentPage = new ContentPage
            {
                Content = new StackLayout
                {
                    Children =
                    {
                        new Label
                        {
                        Text = "Sangvinik",
                        FontSize = Device.GetNamedSize (NamedSize.Medium, typeof(Label)),
                        },
                        new Image {Source = "sangvinik.jpg"}

                    }
                }
            };
            var greenContentPage = new ContentPage
            {
                Content = new StackLayout
                {
                    Children =
                    {
                        new Label
                        {
                        Text = "Flegmatik",
                        FontSize = Device.GetNamedSize (NamedSize.Medium, typeof(Label)),
                        },
                        new Image {Source = "flegmatik.jpg"}

                    }
                }
            };
            var yellowContentPage = new ContentPage
            {
                Content = new StackLayout
                {
                    Children =
                    {
                        new Label
                        {
                        Text = "Melanholik",
                        FontSize = Device.GetNamedSize (NamedSize.Medium, typeof(Label)),
                        },
                        new Image {Source = "melanholik.jpg"}

                    }
                }
            };
            Children.Add(redContentPage);
            Children.Add(greenContentPage);
            Children.Add(blueContentPage);
            Children.Add(yellowContentPage);
        }
    }
}
