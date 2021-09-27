using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CalculadoraBasica
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CalcularButton_Click(object sender, RoutedEventArgs e)
        {
            switch (OperadorTextBox.Text)
            {
                case "*":
                    SolucionTextBox.Text = (double.Parse(Operando1TextBox.Text) * double.Parse(Operando2TextBox.Text)).ToString();
                    break;
                case "/":
                    SolucionTextBox.Text = (double.Parse(Operando1TextBox.Text) / double.Parse(Operando2TextBox.Text)).ToString();
                    break;
                case "+":
                    SolucionTextBox.Text = (double.Parse(Operando1TextBox.Text) + double.Parse(Operando2TextBox.Text)).ToString();
                    break;
                case "-":
                    SolucionTextBox.Text = (double.Parse(Operando1TextBox.Text) - double.Parse(Operando2TextBox.Text)).ToString();
                    break;
            }
        }

        private void LimpiarButton_Click(object sender, RoutedEventArgs e)
        {
            Operando1TextBox.Text = "";
            Operando2TextBox.Text = "";
            OperadorTextBox.Text = "";
            SolucionTextBox.Text = "";
            CalcularButton.IsEnabled = false;
        }

        private void OperadorTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            switch (OperadorTextBox.Text)
            {
                case "*":
                case "/":
                case "+":
                case "-": CalcularButton.IsEnabled = true;
                    break;
                default: CalcularButton.IsEnabled = false;
                    break;
            }
        }
    }
}
