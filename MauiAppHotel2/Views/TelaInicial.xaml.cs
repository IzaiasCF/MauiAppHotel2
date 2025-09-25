namespace MauiAppHotel2.Views;

public partial class TelaInicial : ContentPage
{
	public TelaInicial()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		try
		{
			Navigation.PushAsync(new ContratacaoHospedagem((App)Application.Current));
		}
		catch (Exception ex)
		{
			DisplayAlert("Aviso", ex.Message, "Ok");
		}
    }
}