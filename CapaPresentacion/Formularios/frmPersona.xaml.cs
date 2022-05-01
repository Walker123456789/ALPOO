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

namespace CapaPresentacion
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

        private static CapaNegocio.Alumno alumno = new CapaNegocio.Alumno();
        
        private void btnLeer_Click(object sender, RoutedEventArgs e)
        {
            alumno.Apellidos = txtApellidos.Text.Trim();
            alumno.Codigo = txtCodigo.Text.Trim();
            alumno.Correo = txtCorreo.Text.Trim();
            alumno.Domicilio = txtDomicilio.Text.Trim();
            alumno.LugarNac = txtLugarNac.Text.Trim();
            alumno.Nombres = txtNombre.Text.Trim();
            alumno.Escuela = txtEscuela.Text.Trim();
            alumno.MetodoEstu = txtMetodoEstudio.Text.Trim();
            alumno.FechaNac = Convert.ToDateTime(dtpFechaNacimiento.Text);
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

            MessageBox.Show("Apellidos:" + apellidos + "<br>" + "Codigo:" + codigo + "<br>"+
                "Correo:" + correo +"<br>"+ "Domicilio:" + domicilio + "<br>"+ "Lugar de Nacimiento:" 
                + lugarNac +"<br>"+ "Nombres:" + nombres +"<br>"+ "Escuela:" + escuela + "<br>"+"Método de estudio:" + metodoEstu);
        }
        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

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
    }
}
