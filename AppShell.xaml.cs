using ChekaT2.Handlers;
namespace ChekaT2
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {

           
            InitializeComponent();
        }

        private async void TapGestureRecognizer_Tapped_For_Perfil(object sender, EventArgs e)
        {
        await Shell.Current.GoToAsync("//Perfil");
        }

        private async void TapGestureRecognizer_Tapped_For_SignIn(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//SignIn");
        }
    }
}