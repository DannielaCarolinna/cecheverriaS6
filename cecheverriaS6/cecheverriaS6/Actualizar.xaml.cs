using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace cecheverriaS6
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Actualizar : ContentPage
    {
        public Actualizar()
        {
            InitializeComponent();
        }
        private void btnActualizar_Clicked(object sender, EventArgs e)
        {
            try
            {
                WebClient client = new WebClient();
                var parametros = new System.Collections.Specialized.NameValueCollection();
                parametros.Add("codigo", txtCodigo.Text);
                parametros.Add("nombre", txtNombre.Text);
                parametros.Add("apellido", txtApellido.Text);
                parametros.Add("edad", txtEdad.Text);

                client.UploadValues("http://127.0.0.1/moviles/post.php", "PUT", parametros);
                DisplayAlert("ALERTA", "Dato Ingresado", "Salir");
            }
            catch (Exception ex)
            {
                DisplayAlert("ALERTA", ex.Message, "Cerrar");
            }
        }

        private void btnRegresar_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainPage());
        }

    }
}