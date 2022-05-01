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

namespace CapaPresentación
{
    /// <summary>
    /// Lógica de interacción para frmAdministrativo.xaml
    /// </summary>
    public partial class frmAdministrativo : Window
    {
        public frmAdministrativo()
        {
            InitializeComponent();
        }

        private static CapaNegocio.Administrativo administrativo = new CapaNegocio.Administrativo();

        private void btnLeer_Click(object sender, RoutedEventArgs e)
        {
            administrativo.Apellidos = txtApellidos.Text.Trim();
            administrativo.Nombres = txtNombres.Text.Trim();
            administrativo.Codigo = txtCodigo.Text.Trim();
            administrativo.Correo = txtCorreo.Text.Trim();
            administrativo.Domicilio = txtDomicilio.Text.Trim();
            administrativo.LugarNac = txtLugarNac.Text.Trim();
            administrativo.FechaNac = (DateTime)dtpFechaNac.SelectedDate;
            administrativo.Ganancia = txtGanancia.Text.Trim();
            administrativo.Puesto = txtPuesto.Text.Trim();
            MessageBox.Show("ok, los datos han sido ingresados correctamente");
        }

        private void btnEscribir_Click(object sender, RoutedEventArgs e)
        {
            string apellidos = administrativo.Apellidos;
            string nombres = administrativo.Nombres;
            string codigo = administrativo.Codigo;
            string correo = administrativo.Correo;
            string domicilio = administrativo.Domicilio;
            string lugarNac = administrativo.LugarNac;
            DateTime fechaNac = administrativo.FechaNac;
            string ganancia = administrativo.Ganancia;
            string puesto = administrativo.Puesto;
            MessageBox.Show("Apellidos:"+apellidos+ "\nNombres:" +nombres+ "\nCódigo:" +codigo
                + "\nCorreo:" +correo+ "\nDimicilio:" +domicilio+ "\nLugar de Nacimiento:" +lugarNac+
                "\nFecha de Nacimiento:" +fechaNac+ "\nGanancia:" +ganancia+ "Puesto:" +puesto);
        }
        private void btnMetodo1_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(administrativo.Asistir());
        }

        private void btnMetodo2_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(administrativo.Existir());
        }

        private void btnMetodo3_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("El método Actualizar aún no ha sido implementado");
        }

        private void btnMetodo4_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("El método Agregar aún no ha sido implementado");
        }

        private void btnMetodo5_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("El método Buscar aún no ha sido implementado");
        }

        private void btnMetodo6_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("El método eliminar no ha sido implementado aún");
        }

        private void btnMetodo7_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("El método Listar aún no ha sido implementado");
        }
    }
}
