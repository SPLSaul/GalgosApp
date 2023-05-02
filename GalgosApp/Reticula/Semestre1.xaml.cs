namespace GalgosApp.Reticula;

public partial class Semestre1 : ContentPage
{
	public Semestre1()
	{
        InitializeComponent();
        BindingContext = this;
        List<ReticulaClase> listaDeObjetos = new List<ReticulaClase>()
        {
          new ReticulaClase() { Nombre = "Topicos Avanzados de Programacion", Clave = "SCD - 1027"},
           new ReticulaClase() { Nombre = "Ecuaciones Diferenciales", Clave = "ACF - 0905" },
            new ReticulaClase() { Nombre = "Metodos Numericos", Clave = "SCC - 1017"},
            new ReticulaClase() { Nombre = "Fundamentos de Base de Datos", Clave = "AEF - 1031"}
        };
        colleciontView.ItemsSource = listaDeObjetos;
    }
}