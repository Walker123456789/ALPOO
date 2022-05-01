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
    /// Lógica de interacción para frmAlumno.xaml
    /// </summary>
    public partial class frmAlumno : Window
    {
        public frmAlumno()
        {
            InitializeComponent();
        }

        private static CapaNegocio.Alumno alumno = new CapaNegocio.Alumno();

        private void btnLeer_Click(object sender, RoutedEventArgs e)
        {
            alumno.Apellidos = txtApellidos.Text.Trim();
            alumno.Codigo = txtCodigo.Text.Trim();
            alumno.Correo = txtCorreo.Text.Trim();
            alumno.Domicilio = txtDomicilio.Text.Trim();
            alumno.LugarNac = txtLugarNac.Text.Trim();
            alumno.Nombres = txtNombres.Text.Trim();
            alumno.Escuela = txtEscuela.Text.Trim();
            alumno.MetodoEstu = txtMetodoEstudio.Text.Trim();
            alumno.FechaNac = (DateTime)dtpFechaNac.SelectedDate;
            if (cboSeguro.SelectedIndex >= 0)
            {
                alumno.Seguro = Convert.ToBoolean(cboSeguro.Text);
            }
            else MessageBox.Show("Seleccione una opción correcta");
            
            MessageBox.Show("Los datos han sido ingresados correctamente");
        }

        private void btnEscribir_Click(object sender, RoutedEventArgs e)
        {
            string apellidos = alumno.Apellidos;
            string codigo = alumno.Codigo;
            string correo = alumno.Correo;
            string domicilio = alumno.Domicilio;
            string lugarNac = alumno.LugarNac;
            string nombres = alumno.Nombres;
            string escuela = alumno.Escuela;
            string metodoEstu = alumno.MetodoEstu;
            DateTime FechaNac = alumno.FechaNac;
            bool seguro = alumno.Seguro;

            MessageBox.Show("Apellidos:" + apellidos + "\nCodigo:" + codigo + "\nCorreo:" + correo + 
                "\nDomicilio:" + domicilio + "\nLugar de Nacimiento:"
                + lugarNac + "\nNombres:" + nombres + "\nEscuela:" + escuela +
                "\nMétodo de estudio:" + metodoEstu + "\nFecha de Nacimiento:" + 
                FechaNac + "\nSeguro:" + seguro);
        }

        private void btnMetodo1_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(alumno.Asistir());
        }

        private void btnMetodo2_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(alumno.Existir());
        }

        private void btnMetodo3_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(alumno.Estudiar());
        }

        private void cboSeguro_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
