﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace biletix3.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Deneme : TabbedPage
    {
        public Deneme()
        {
            InitializeComponent();
            
        }

        async void filter_Clicked(object sender, EventArgs e)
        {      
            await Navigation.PushAsync(new Fav());
        }
    }
}