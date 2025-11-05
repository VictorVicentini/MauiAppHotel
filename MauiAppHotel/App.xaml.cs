using MauiAppHotel.Models;

namespace MauiAppHotel
{
    public partial class App : Application
    {
        public List<Quarto> lista_quartos = new List<Quarto>
        {
            new Quarto() 
            {   descricao = "Quarto Standard", 
                valorDiariaAdulto = 150.00, 
                valorDiariaCrianca = 75.00 
            },
            new Quarto() 
            { 
                descricao = "Quarto Deluxe", 
                valorDiariaAdulto = 250.00, 
                valorDiariaCrianca = 125.00 
            },
            new Quarto() 
            { 
                descricao = "Suíte Executiva", 
                valorDiariaAdulto = 400.00, 
                valorDiariaCrianca = 200.00 
            }
        };
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Views.ContratacaoHospedagem());
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            var window = base.CreateWindow(activationState);

            window.Width = 400;
            window.Height = 600;

            return window;
        }
    }
}
