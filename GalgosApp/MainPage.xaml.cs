namespace GalgosApp;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void btnIngresarClicked(object sender, EventArgs e)
	{
        if (!string.IsNullOrEmpty(entryNo_Control.Text) && !string.IsNullOrEmpty(entryPassword.Text))
        {
            string user = "Saul";
            string password = "carlos123";
            if (entryNo_Control.Text != user && entryPassword.Text != password)
            {
                DisplayAlert("Error", "Usuario o contraseña incorrectos", "Ok");
            }
            else
            {
                DisplayAlert("Inicio", $"Bienvenido {user}", "Ok");
                Navigation.PushAsync(new Materias());
            }
        }
        else if (entryNo_Control.Text == null || entryPassword.Text == null)
        {
            //DisplayAlert("Error", "No hay valores ingresados", "Ok");
            Navigation.PushAsync(new Materias());
        }
    }
}

