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
using System.Windows.Shapes;

namespace Lab02
{
    /// <summary>
    /// Lógica de interacción para HomeWindow.xaml
    /// </summary>
    public partial class HomeWindow : Window
    {
        public HomeWindow()
        {
            InitializeComponent();
        }

        private void OperacionesSalidaClick(object sender, RoutedEventArgs e)
        {
            OperacionesSalidadWindow windowOperacionesSalida = new OperacionesSalidadWindow();
            windowOperacionesSalida.Show();
        }
        private void MantenimientoCamionesClick(object sender, RoutedEventArgs e)
        {
            MantenimientoCamionesWindow windowMantenimientoCamiones = new MantenimientoCamionesWindow();
            windowMantenimientoCamiones.Show();
        }
        private void MantenimientoConductoresClick(object sender, RoutedEventArgs e)
        {
            MantenimientoConductores windowMantenimientoConductores = new MantenimientoConductores();
            windowMantenimientoConductores.Show();
        }
    }
}
