namespace ExamenS4.Vistas;

public partial class vResumen : ContentPage
{
	public vResumen(string nombre1,string apellido1,string edad1,string fecha1, string pais1, string ciudad1)
	{
		InitializeComponent();
		nombre.Text = nombre1;
		apellido.Text = apellido1;
		edad.Text = edad1;
		fecha.Text = fecha1;
		pais.Text = pais1;
		lblciudad.Text = ciudad1;

	}
}