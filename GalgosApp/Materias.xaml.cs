namespace GalgosApp;

public partial class Materias : ContentPage
{
	public Materias()
	{
		InitializeComponent();
        BindingContext = this;
        List<MateriasClase> listaDeObjetos = new List<MateriasClase>()
        {
          new MateriasClase() { Nombre = "Arquitectura de computadoras", Horario = "10:00 - 11:00", Salon = "Lab. D" },
    new MateriasClase() { Nombre = "Ecuaciones Diferenciales", Horario = "11:00 - 12:00", Salon = "9306" },
    new MateriasClase() { Nombre = "Metodos Numericos", Horario = "12:00 - 13:00", Salon = "9307" }
};
        colleciontView.ItemsSource = listaDeObjetos;
    }
}