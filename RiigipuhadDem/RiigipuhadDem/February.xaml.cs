using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RiigipuhadDem
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class February : ContentPage
    {
        public February()
        {
            InitializeComponent();
            AbsoluteLayout absoluteLayout = new AbsoluteLayout();
            absoluteLayout.Children.Add(
                new Label { Text = "February 2021", FontSize = 30 },
                new Rectangle(300, 20, 150, 60)
            );
            absoluteLayout.Children.Add(
                new Label { Text = "Days in the month", FontSize = 25 },
                new Rectangle(30, 100, 200, 60)
            );
            absoluteLayout.Children.Add(
                new Label { Text = "The calendar: 28 days", FontSize = 15 },
                new Rectangle(30, 150, 200, 60)
            );
            absoluteLayout.Children.Add(
                new Label { Text = "Working days: 19 days", FontSize = 15 },
                new Rectangle(30, 200, 200, 60)
            );
            absoluteLayout.Children.Add(
                new Label { Text = "Weekends and holidays: 9 days", FontSize = 15 },
                new Rectangle(30, 250, 230, 60)
            );
            absoluteLayout.Children.Add(
                new Label { Text = "Weekends and holidays", FontSize = 25 },
                new Rectangle(380, 100, 280, 60)
            );
            absoluteLayout.Children.Add(
                new Label { Text = "The 23rd: Defender of the Fatherland Day", FontSize = 15 },
                new Rectangle(380, 150, 280, 60)
            );
            Content = absoluteLayout;
        }
    }
}