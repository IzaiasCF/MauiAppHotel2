using MauiAppHotel2.Models;

namespace MauiAppHotel2
{
    public partial class App : Application
    {
        public List<Quarto> lista_quartos = new List<Quarto>
        {
            new Quarto()
            {
                Descricao = "Suite Super Luxo",
                ValorDiariaAdulto = 110.00,
                ValorDiariaCrianca = 55.00
            },

            new Quarto()
            {
                Descricao = "Suite Luxo",
                ValorDiariaAdulto = 80.00,
                ValorDiariaCrianca = 40.00
            },

            new Quarto()
            {
                Descricao = "Suite Single",
                ValorDiariaAdulto = 50.00,
                ValorDiariaCrianca = 25.00
            },

            new Quarto()
            {
                Descricao = "Suite Basica",
                ValorDiariaAdulto = 25.00,
                ValorDiariaCrianca = 12.00
            }
        };

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
