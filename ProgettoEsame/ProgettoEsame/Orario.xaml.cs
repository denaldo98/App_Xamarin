﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProgettoEsame
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Orario : TabbedPage
    {
        public Orario()
        {
            InitializeComponent();
            Title = "Orario";
        }
    }
}