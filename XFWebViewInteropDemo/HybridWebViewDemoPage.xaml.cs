﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XFWebViewInteropDemo
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HybridWebViewDemoPage : ContentPage
    {
        public HybridWebViewDemoPage()
        {
            InitializeComponent();
        }

        private void sendToWebViewButton_Clicked(object sender, EventArgs e)
        {
            
        }
    }
}