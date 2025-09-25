namespace MauiAppHotel2
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            // MainPage = new AppShell();
            // Alterando a página inicial
            MainPage = new NavigationPage(new Views.ContratacaoHospedagem());
        }

        // Definição da largura/altura do App
        protected override Window CreateWindow(IActivationState? activationState)
        {
            var window = base.CreateWindow(activationState);

            window.Width = 400;  /* Altura */
            window.Height = 700;  /* Largura */

            return window;
        }
    }
}
