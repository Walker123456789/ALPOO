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
    /// Lógica de interacción para frmDocente.xaml
    /// </summary>
    public partial class frmDocente : Window
    {
        public frmDocente()
        {
            InitializeComponent();
        }

        private static CapaNegocio.Docente docente = new CapaNegocio.Docente();

        private void btnLeer_Click(object sender, RoutedEventArgs e)
        {
            docente.Apellidos = txtApellidos.Text.Trim();
            docente.Nombres = txtNombres.Text.Trim();
            docente.Codigo = txtCodigo.Text.Trim();
            docente.Correo = txtCorreo.Text.Trim();
            docente.Domicilio = txtDomicilio.Text.Trim();
            docente.LugarNac = txtLugarNac.Text.Trim();
            docente.Afp = txtAfp.Text.Trim();
            docente.EstadoCivil = txtEstadoCivil.Text.Trim();
            docente.Profesion = txtProfesion.Text.Trim();
            docente.FechaNac = (DateTime)dtpFechaNac.SelectedDate;
            MessageBox.Show("ok, los datos han sido ingresados correctamente");
        }

        private void btnEscribir_Click(object sender, RoutedEventArgs e)
        {
            string apellidos = docente.Apellidos;
            string nombres = docente.Nombres;
            string codigo = docente.Codigo;
            string correo = docente.Correo;
            string domicilio = docente.Domicilio;
            string lugarNac = docente.LugarNac;
            string afp = docente.Afp;
            string estadoCivil = docente.EstadoCivil;
            string profesion = docente.Profesion;
            DateTime fechaNac = docente.FechaNac;
            MessageBox.Show("Apellidos:"+apellidos+"\nNombres:"+nombres+"\nCódigo:"+codigo
                + "\nCorreo:"+correo+ "\nDomicilio:"+domicilio+"\nFecha de Nacimiento:"+fechaNac+"\nLugar de Nacimiento:"+lugarNac+
                "\nAFP:"+afp+ "\nEstado Civil:"+estadoCivil+ "\nProfesión:"+profesion);
        }

        private void btnMetodo1_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(docente.Asistir());
        }

        private void btnMetodo2_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(docente.Existir());
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
