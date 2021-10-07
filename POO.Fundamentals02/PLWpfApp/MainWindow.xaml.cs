using BLL;
using System;
using System.Windows;

namespace PLWpfApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        Circunferencia rueda;
        Circunferencia moneda;
        public MainWindow()
        {
            InitializeComponent();
            rueda = new Circunferencia();
            moneda = new Circunferencia();
          
            ButtonCalcularArea.IsEnabled = false;
            ButtonCalcularPerimetro.IsEnabled = false;
        }

        private void CapturarRadio_Click(object sender, RoutedEventArgs e)
        {
            if (TextBoxRadio.Text == String.Empty)
            {
                LabelResultado.Content = "$Debe ingresar un valor de radio válido ";
            }
            else
            {
                if (RadioButtonRueda.IsChecked == true)
                {
                     rueda.ModificarRadio(Convert.ToDouble(TextBoxRadio.Text));
                    ActivarBotones();
                }
    
                else
                if (RadioButtonMoneda.IsChecked == true)
                {
                    moneda.ModificarRadio(Convert.ToDouble(TextBoxRadio.Text));
                    ActivarBotones();
                }
                else
                {
                    LabelResultado.Content = $"Debe seleccionar un objeto válido ";
                }
            }
        }

        private void CalcularArea_Click(object sender, RoutedEventArgs e)
        {
            if (RadioButtonRueda.IsChecked == true)
            {
               var resultado = rueda.CalcularArea();
                LabelResultado.Content = $"El área de la rueda es {resultado.ToString()}";
            }
            else if (RadioButtonMoneda.IsChecked == true)
            {
                var resultado = moneda.CalcularArea();
                LabelResultado.Content = $"El área de la moneda es {resultado.ToString()}";
            }
        }

        private void CalcularPerimetro_Click(object sender, RoutedEventArgs e)
        {
            if (RadioButtonRueda.IsChecked == true)
            {
                var resultado = rueda.CalcularPerimetro();
                LabelResultado.Content = $"El Perimetro de la rueda es {resultado.ToString()}";
            }
            else if (RadioButtonMoneda.IsChecked == true)
            {
                var resultado = rueda.CalcularPerimetro();
                LabelResultado.Content = $"El Perimetro de la moneda es {resultado.ToString()}";
            }
        }

        private void Salir_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ActivarBotones()
        {

            ButtonCalcularArea.IsEnabled = true;
            ButtonCalcularPerimetro.IsEnabled = true;
        }

        
    }
}