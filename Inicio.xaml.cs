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

    DatePicker datePicker = new DatePicker
    {
        MinimumDate = new DateTime(1900, 1, 1),
        MaximumDate = new DateTime(2100, 12, 31),
        Date = new DateTime(2018, 6, 21)
    };
}