using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace cecheverriaS6
{
    public partial class MainPage : ContentPage
    {
        private const string Url = "http://127.0.0.1/moviles/post.php";
        private readonly HttpClient client = new HttpClient();
        private ObservableCollection<cecheverriaS6.Ws.Datos> _post;
        public MainPage()
        {
            InitializeComponent();
            Obtener();
        }
       public async void Obtener ()
        {
            var content = await client.GetStringAsync(Url);
            List<cecheverriaS6.Ws.Datos> posts = JsonConvert.DeserializeObject<List<cecheverriaS6.Ws.Datos>>(content);
            _post = new ObservableCollection<cecheverriaS6.Ws.Datos>(posts);

            MyListView.ItemsSource = _post;
        }
       private void btnInsertar_Clicked(object sender, EventArgs e)
       {
            var message = "BIENVENIDOS";
            DependencyService.Get<Message>().LongAlert(message);
            Navigation.PushAsync(new Insertar());
       }

        private void btnActualizar_Clicked(object sender, EventArgs e)
        {
            var message = "BIENVENIDOS";
            DependencyService.Get<Message>().LongAlert(message);
            Navigation.PushAsync(new Actualizar());
        }

        private void btnEliminar_Clicked(object sender, EventArgs e)
        {
            var message = "BIENVENIDOS";
            DependencyService.Get<Message>().LongAlert(message);
            Navigation.PushAsync(new Eliminar());
        }
    }
}
