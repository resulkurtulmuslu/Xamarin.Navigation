﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Mobile.Navigation
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ThirdPage : ContentPage
    {
        public ThirdPage()
        {
            InitializeComponent();
        }

        async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

        async void Button_Clicked_1(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationModelPage("Resul Kurtulmuşlu"));
        }
    }
}