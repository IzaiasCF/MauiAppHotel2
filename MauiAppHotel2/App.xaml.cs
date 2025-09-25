namespace MauiAppHotel2
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            // MainPage = new AppShell();
            // Alterando a página inicial:
            MainPage = new NavigationPage(new Views.TelaInicial());
        }

        // Definição da largura/altura do App
        protected override Window CreateWindow(IActivationState? activationState)
        {
            var window = base.CreateWindow(activationState);

            window.Width = 350;  /* Largura */
            window.Height = 700;  /* Altura */

            return window;
        }
    }
}
