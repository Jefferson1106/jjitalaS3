namespace jjitalaS3.Views;

public partial class vLogin : ContentPage
{
    string usuario;
    string contraseña;
	public vLogin()
	{
		InitializeComponent();
	}

    public vLogin(string usuarionuevo,string contrasenaNueva)
    {
        InitializeComponent();
		usuario = usuarionuevo;
		contraseña= contrasenaNueva;
    }

    private async void btnIniciarSesion_Clicked(object sender, EventArgs e)
    {
		try
		{
			string usuarioIngresado = txtUsuario.Text;
			string contraseñaIngresada = txtcontrasena.Text;
			if (usuario == usuarioIngresado && contraseña == contraseñaIngresada)
			{
				await Navigation.PushAsync(new vPrincipal(usuario));
			}
			else
			{
                await DisplayAlertAsync("ERROR", "Usuario/Contraseña Incorrectos", "Cerrar");
				txtUsuario.Text = "";
				txtcontrasena.Text = "";
            }
		}
		catch (Exception ex)
		{

			await DisplayAlertAsync("ERROR",ex.Message, "Cerrar");
		}
    }

    private async void btnRegistrarUsuario_Clicked(object sender, EventArgs e)
    {
		await Navigation.PushAsync(new vRegistro());
    }
}