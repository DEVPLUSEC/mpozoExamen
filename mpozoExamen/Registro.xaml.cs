using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace mpozoExamen
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Registro : ContentPage
    {
        string user;

        public Registro(string usuario)
        {
            InitializeComponent();
            lblUsuario.Text = "Usuario Conectado: " + usuario;
            this.user = usuario;
        }

        private void btnResumen_Clicked(object sender, EventArgs e)
        {
            string dato_1 = txtNombre.Text;
            string dato_2 = txtApellido.Text;
            string dato_3 = Convert.ToString(txtEdad.Text);
            string fecha = txtFecha.Date.ToString("MMM/dd/yyyy}"); ;

            string pais = pkPais.Items[pkPais.SelectedIndex];

            if (pkPais.SelectedIndex == -1)
            {
                DisplayAlert("Alerta", "Seleccione un pais", "Cancelar");
            }
            string ciudad = pkCiudad.Items[pkCiudad.SelectedIndex];
            if (pkCiudad.SelectedIndex == -1)
            {
                DisplayAlert("Alerta", "Seleccione un pais", "Cancelar");
            }

            string pagoInicial = Convert.ToString(txtMon.Text);
            string pagoMensual = Convert.ToString(txtMensual.Text);



            if ((dato_1 != null && dato_1 != "") && (dato_2 != null && dato_2 != "")
                && (dato_3 != null && dato_3 != "") && (pais != null && pais != "")
                && (ciudad != null && ciudad != "") && (pagoInicial != null && pagoInicial != "")
                && (pagoMensual != null && pagoMensual != ""))
            {
                Navigation.PushAsync(new Resumen(user, dato_1, dato_2, dato_3, pais, ciudad, pagoInicial, pagoMensual, fecha));

                //DisplayAlert("Alto", "Llene Todos los campos", "Cancelar");
            }
            else
            {
                DisplayAlert("Alto", "Llene Todos los campos", "Cancelar");
            }


        }

        private void btnPago_Clicked(object sender, EventArgs e)
        {
            int mensual = Convert.ToInt32(txtMon.Text);

            if (mensual > 1500)
            {
                DisplayAlert("Alerta", "El valor inicial no puede ser superior a 1500", "Cancelar");
            }
            else if(mensual < 0)
            {
                DisplayAlert("Alerta", "El valor inicial no puede ser menor a 0", "Cancelar");

            }
            else
            {
                int valor_restante = 1500 - mensual;
                int valor_divido = valor_restante / 4;
                double valor_cuota = 1500 * 0.04;
                double valor_cuota_total = valor_cuota + valor_divido;
                txtMensual.Text = valor_cuota_total.ToString();

            }



        }
    }
}