namespace ChekaT2;

public partial class Actividades : ContentPage
{
	public Actividades()
	{
		InitializeComponent();
	}

    private async void TapGestureRecognizer_Tapped_For_Inicio(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//Inicio");
    }
}