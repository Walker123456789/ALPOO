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

namespace CapaPresentación
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

        private void MenuSalir_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void menuAlumno_Click(object sender, RoutedEventArgs e)
        {

            CapaPresentación.frmAlumno frm = new CapaPresentación.frmAlumno();
            frm.Show();
        }

        private void menuDocente_Click(object sender, RoutedEventArgs e)
        {
            CapaPresentación.frmDocente frm = new CapaPresentación.frmDocente();
            frm.Show();
        }

        private void menuAdministrativo_Click(object sender, RoutedEventArgs e)
        {
            CapaPresentación.frmAdministrativo frm = new CapaPresentación.frmAdministrativo();
            frm.Show();
        }
    }
}
