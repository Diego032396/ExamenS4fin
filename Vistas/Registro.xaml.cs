
namespace ExamenS4.Vistas;

public partial class Registro : ContentPage
{
	public Registro(string usuarioIngresado)
	{
		InitializeComponent();
        lblUsuario.Text = "Conectado como: " + usuarioIngresado;
        
    }

    private void btnCalcular_Clicked(object sender, EventArgs e)
    {
        double.TryParse(txtMomto.Text, out double monto);
        double iniial = 3000;
        double iva = (iniial * 5 /100);
        double total1=(iniial - monto);
        double total2 = (total1 / 3+ iva);

        txtMensual.Text = total2.ToString();

    }

    private void btnResumen_Clicked(object sender, EventArgs e)
    {
        int monto = int.Parse(txtMomto.Text);
        string fecha = dpFecha.Date.ToString();
        string pais = pkPais.Items[pkPais.SelectedIndex].ToString();
        string ciudad = pkCiudad.Items[pkCiudad.SelectedIndex].ToString();
        Navigation.PushAsync(new vResumen(txtNombre.Text, txtApellido.Text, txtEdad.Text, fecha, pais, ciudad));

    }
}