﻿using cvapp;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace cvapp
{
    public partial class App : Application
    {
        public App()
        {
            // 
            InitializeComponent();
            // Especificando la pagina de arranque
            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
