﻿using ProgettoEsame.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProgettoEsame
{
  
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SignUpPage : ContentPage
    {
        IFirebaseAuth auth;
        public SignUpPage()
        {
            InitializeComponent();
            auth = DependencyService.Get<IFirebaseAuth>();
        }

        async void BtnRegistra_Clicked(object sender, EventArgs e)
        {
            string mail = txtMail.Text;
            string pass = txtPass.Text;
            //string confpass = txtConfPass.Text;
            //string nome = txtnome.Text;
            //string cognome = txtCognome.Text;

            string token = await auth.DoRegisterWithEP(mail, pass);
            //await DisplayAlert("ok", token, "OK");
            if (token != "") //registrazione OK
            {
                await DisplayAlert("Success", "Registration completed", "OK");
                await Navigation.PushAsync(new Page1());
                Navigation.RemovePage(this);
            }
            else //errore nella registrazione
            {
                ShowError();
            }
        }



        /*async void BtnRegistra_Clicked((object sender, EventArgs e)
        {
            bool created = auth.DoRegisterWithEP(mail, pass);
            if (created)
            {
                await DisplayAlert("Success", "Registration completed", "OK");
                await Navigation.PushAsync(new Page1());
                Navigation.RemovePage(this);
            }
            else
            {
                await DisplayAlert("Sign Up Failed", "Something went wrong. Try again!", "OK");
            }
        }*/





        async private void ShowError() //inserire controlli
        {
            await DisplayAlert("Sign Up Failed", "E-mail or password are incorrect. Try again!", "OK");
        }

        async void BtnToLogin_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LoginPage());
            Navigation.RemovePage(this);
        }
    }
}