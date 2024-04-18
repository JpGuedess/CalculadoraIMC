using System.Drawing;

namespace CalculadoraIMC
{
    public partial class MainPage : ContentPage
    {

        const double AbaixoDoPeso = 18.5;
        const double PesoNormal = 24.9;
        const double AcimaDoPeso = 29.9;

        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            var peso = double.Parse(Peso.Text);
            var altura = double.Parse(Altura.Text) / 100;

            var imc = peso / (altura * altura);

            IMC.Text = imc.ToString("F2");
            IMCNum.Text = imc.ToString("F2");
            
            string resultado = GetImcMensagem(imc);
            
        }

        private string GetImcMensagem(double imc)
        {
            if(imc <= AbaixoDoPeso)
            {
                return IMC.Text = imc.ToString("Você está abaixo do peso, seu imc é:");
            }
            if (imc <= PesoNormal)
            {
                return IMC.Text = imc.ToString("Você no peso normal, seu imc é:");
            }
            if (imc <= AcimaDoPeso)
            {
                return IMC.Text = imc.ToString("Você está acima do peso, seu imc é:");
            }
            else 
            {
                return IMC.Text = imc.ToString("Você está obeso, tome cuidado com sua saude!!! seu imc é:");
            }
        }


 
    }

}
