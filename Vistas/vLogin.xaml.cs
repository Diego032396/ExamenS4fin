namespace ExamenS4.Vistas;

public partial class vLogin : ContentPage
{
    string[] usuarios = { "estudiante2024", "examen1", "NombreEstudiante" };
    string[] contrasenas = { "uisrael2024", "parcial1", "2024" };
    public vLogin()
	{
		InitializeComponent();
	}

    private void btnInicio_Clicked(object sender, EventArgs e)
    {
        string usuarioIngresado = txtUsario.Text;
        string contrasenaIngresada = txtContrasena.Text;

        bool credencialesValidas = false;

        for (int i = 0; i < usuarios.Length; i++)
        {
            if (usuarios[i] == usuarioIngresado && contrasenas[i] == contrasenaIngresada)
            {
                credencialesValidas = true;
                DisplayAlert("Bienvenid@ " + usuarioIngresado, usuarioIngresado + " Ingresaste corectamente al simulador de Pagos Uisrael ", "Aceptar");
                Navigation.PushAsync(new Registro(usuarioIngresado));
            }
        }
        if (!credencialesValidas)
        {
            DisplayAlert("Error", "Usuario o contraseña incorrectos", "Aceptar");
        }

    }

    private void btnAcerca_Clicked(object sender, EventArgs e)
    {

    }
}
