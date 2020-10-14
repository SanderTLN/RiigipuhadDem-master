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
    public partial class February : ContentPage
    {
        public February()
        {
            Button btn1, btn2;
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
            absoluteLayout.Children.Add(
                btn1 = new Button { Text = "More", FontSize = 10 },
                new Rectangle(315, 143, 60, 35)
            );
            absoluteLayout.Children.Add(
                btn2 = new Button { Text = "More", FontSize = 10 },
                new Rectangle(315, 193, 60, 35)
            );
            btn1.Clicked += Btn1_Clicked;
            btn2.Clicked += Btn2_Clicked;
            Content = absoluteLayout;
        }

        private void Btn1_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Defender of the Fatherland Day", "Defender of the Fatherland Day is a holiday observed in Russia, Turkmenistan, Belarus, Kyrgyzstan, Kazakhstan and Tajikistan." +
                " It is celebrated on 23 February, except in Kazakhstan, where it is celebrated on 7 May.", "OK");
        }
        private void Btn2_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Independence Day", "Independence Day is a national holiday in Estonia marking the anniversary of the Estonian Declaration of Independence in 1918." +
                " It is commonly celebrated with concerts, parades and parties." +
                " It is the national day of Estonia.", "OK");
        }
    }
}