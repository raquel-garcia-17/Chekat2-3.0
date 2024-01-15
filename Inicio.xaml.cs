namespace ChekaT2;

public partial class Inicio : ContentPage
{
	public Inicio()
	{
		InitializeComponent();
	}
    private async void TapGestureRecognizer_Tapped_For_Checador(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//Checador");
    }
    private async void TapGestureRecognizer_Tapped_For_Cumpleaños(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//Cumpleaños");
    }
    private async void TapGestureRecognizer_Tapped_For_Actividades(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//Actividades");
    }
    private async void TapGestureRecognizer_Tapped_For_Recordatorios(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//Recordatorios");
    }
}