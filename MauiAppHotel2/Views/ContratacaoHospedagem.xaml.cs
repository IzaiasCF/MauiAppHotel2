namespace MauiAppHotel2.Views;

public partial class ContratacaoHospedagem : ContentPage
{
	App PropriedadesApp;

	public ContratacaoHospedagem()
	{
		InitializeComponent();

		PropriedadesApp = (App)Application.Current;

		pck_quarto.ItemsSource = PropriedadesApp.lista_quartos;

		dtpck_checking.MinimumDate = DateTime.Now;
		dtpck_checking.MaximumDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month + 1, DateTime.Now.Day);

		dtpck_checkout.MinimumDate = dtpck_checking.Date.AddDays(1);
		dtpck_checkout.MaximumDate = dtpck_checking.Date.AddMonths(6);
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		try
		{
			Navigation.PushAsync(new HospedagemContratada());
		}
		catch (Exception ex)
		{
			DisplayAlert("Aviso", ex.Message, "Ok");
		}
    }
}