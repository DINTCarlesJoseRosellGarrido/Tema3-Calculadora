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

namespace Tema3_Calculadora
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            createButtons();

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Button boton = (Button)sender;
            visor.Text += boton.Tag.ToString();
        }

        private void createButtons()
        {
            int numberText = 1;

            for(int i = 1; i<4; i++)
            {
                for(int j = 0; j<3; j++)
                {
                    Button b = new Button();
                    Viewbox vb = new Viewbox();
                    TextBlock tb = new TextBlock();

                    tb.Text = $"{numberText}";
                    vb.Child = tb;
                    b.Content = vb;

                    b.Style = (Style)this.Resources["calculatorButtonStyle"];
                    //b.Click += button_Click;
                    b.Tag = numberText.ToString();
                    Grid.SetRow(b, i);
                    Grid.SetColumn(b,j);

                    numberGrid.Children.Add(b);

                    numberText++;
                }
            }
        }
    }
}
