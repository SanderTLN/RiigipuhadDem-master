﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RiigipuhadDem
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class March : ContentPage
    {
        public March()
        {
            Button btn1;
            InitializeComponent();
            AbsoluteLayout absoluteLayout = new AbsoluteLayout();
            absoluteLayout.Children.Add(
                new Label { Text = "March 2021", FontSize = 30 },
                new Rectangle(300, 20, 150, 60)
            );
            absoluteLayout.Children.Add(
                new Label { Text = "Days in the month", FontSize = 25 },
                new Rectangle(30, 100, 200, 60)
            );
            absoluteLayout.Children.Add(
                new Label { Text = "The calendar: 31 days", FontSize = 15 },
                new Rectangle(30, 150, 200, 60)
            );
            absoluteLayout.Children.Add(
                new Label { Text = "Working days: 22 days", FontSize = 15 },
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
                new Label { Text = "The 8th: International Women's Day", FontSize = 15 },
                new Rectangle(380, 150, 280, 60)
            );
            absoluteLayout.Children.Add(
                btn1 = new Button { Text = "More", FontSize = 10 },
                new Rectangle(315, 143, 60, 35)
            );
            btn1.Clicked += Btn1_Clicked;
            Content = absoluteLayout;
        }

        private void Btn1_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("International Women's Day", "International Women's Day (IWD) is celebrated on the 8th of March every year around the world.\n" +
                "It is a focal point in the movement for women's rights." +
                " After the Socialist Party of America organized a Women's Day in New York City on February 28, 1909, German delegates Clara Zetkin, Käte Duncker, Paula Thiede and others proposed at the 1910 International Socialist Woman's Conference that" + "a special Women's Day" + "be organized annually." +
                " After women gained suffrage in Soviet Russia in 1917, March 8 became a national holiday there." +
                " The day was then predominantly celebrated by the socialist movement and communist countries until it was adopted by the feminist movement in about 1967." +
                " The United Nations began celebrating the day in 1977.", "OK");
        }
    }
}