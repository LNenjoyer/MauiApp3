namespace MauiApp3
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnObliczPiwo(object? sender, EventArgs e)
        {
            
            Double count1 = pol5.Value;
            
            if (Double.TryParse(pol3.Text, out Double result))
            {
                Double napiwo = result * (count1 / 100);
                pol8.Text = (Math.Round(napiwo, 2)).ToString();
                pol9.Text = (Math.Round((napiwo + result), 2)).ToString();
            }
            else
            {
                pol8.Text = "Niepoprawna kwota w rachunku, nie można obliczyć rachunku";
            }
            
        }
        private void OnWypite(object? sender, EventArgs e)
        {
            pol5.Value = 15;
            pol3.Text = "0";
            pol8.Text = "";
            pol9.Text = "";
        }
    }
}
