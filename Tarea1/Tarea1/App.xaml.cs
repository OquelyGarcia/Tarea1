﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tarea1
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Views.PageOperaciones ();
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
