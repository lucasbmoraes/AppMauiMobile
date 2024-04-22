using Dominio.Entidades;
using Integracao;
using Newtonsoft.Json;

namespace AppMauiMobile
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void CliqueBuscarInformacoes(object sender, EventArgs e)
        {
            string shareSymbol = campoSimbolo.Text;
            ShareDetails shareDetails = new ShareDetails(shareSymbol);
            await Navigation.PushAsync(shareDetails);
            SemanticScreenReader.Announce(BuscarInformacoes.Text);
        }
    }

}
