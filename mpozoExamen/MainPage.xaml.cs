﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace mpozoExamen
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnInicio_Clicked(object sender, EventArgs e)
        {
            string usuario = txtUser.Text;
            string password = txtPass.Text;

            if (usuario == "estudiante2023" && password == "uisrael2023")
            {

                Navigation.PushAsync(new Registro(usuario));

            }
            else
            {
                DisplayAlert("Alerta", "Inicio de sesion erroneo", "Cancelar");
            }


        }
    }
}
