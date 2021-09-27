using MisClases;
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

namespace Hello_World_VPFCs
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

        /// <summary>
        /// evento asociado al click del boton "Button"
        /// que muestra por pantalla un saludo al usuario 
        /// </summary>
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            clsPersona usuario;

            if (string.IsNullOrEmpty(cajita.Text))
            {
                MessageBox.Show("Por favor introduzca su nombre");
            }
            else
            {
                usuario = new clsPersona();
                usuario.Nombre = cajita.Text;
                MessageBox.Show($"Hola {usuario.Nombre}");
            }
        }
    }
}
