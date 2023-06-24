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
    public partial class Resumen : ContentPage
    {
        public Resumen(string usuario, string dato_1, string dato_2, string dato_3, string pais, string ciudad, string pagoInicial, string pagoMensual, string fecha)
        {
            InitializeComponent();
            lblUser.Text = "Usuario Conectado: " + usuario;

              txtNombre.Text = dato_1;
              txtApellido.Text = dato_2;
              txtEdad.Text = dato_3;
              txtFecha.Text = fecha;
              txtCiudad.Text = ciudad;
              txtPais.Text = pais;
              txtMonto.Text = pagoInicial;
              txtMensual.Text = pagoMensual;
              Double total = Convert.ToDouble(pagoInicial) + (Convert.ToDouble(pagoMensual) * 4);
              txtTotal.Text =  total.ToString();
        }


        private void btnSalir_Clicked(object sender, EventArgs e)
        {

        }
    }
}