﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ProgettoEsame.Interfaces;
using ProgettoEsame.View;

namespace ProgettoEsame
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            if(Application.Current.Properties.ContainsKey("logged"))
            {
                if (Application.Current.Properties["logged"].ToString().Equals("true"))
                {
                    MainPage = new HomePage();
                }
            }
            else //utente non loggato: portare alla pagina di login
            {
                MainPage = new NavigationPage(new LoginPage2());
            }

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
