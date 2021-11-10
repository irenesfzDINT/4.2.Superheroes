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

namespace Superheroes
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Superheroe> superheroes = Superheroe.GetSamples();
        int contadorHeroes;
        public MainWindow()
        {
            InitializeComponent();
            ContenedorGrid.DataContext = superheroes.FirstOrDefault();
        }

        private void Image_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if ((sender as Image).Tag.ToString() == "Sumar")
            {
                if (contadorHeroes < 2)
                    contadorHeroes++;
                else contadorHeroes = 0;
            }
            else
            {
                if (contadorHeroes != 0)
                    contadorHeroes--;
                else contadorHeroes = 2;
            }
            ContenedorGrid.DataContext = superheroes[contadorHeroes];
            NumeroPaginasTextBlock.Text = contadorHeroes + 1 + "/3";
        }
    }
}
