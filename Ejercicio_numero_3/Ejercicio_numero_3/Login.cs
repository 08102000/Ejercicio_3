using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Base_Datos;
using Base_Datos.Accesos;
using Base_Datos.Atributos;

namespace Ejercicio_numero_3
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void AceptarButton_Click(object sender, EventArgs e)
        {
            UsuariosBDA UsuarioBDA = new UsuariosBDA();
            Usuario usuario = new Usuario();

            usuario = UsuarioBDA.Login(UsuarioTextBox.Text, ContraseñaTextBox.Text);

            
            Usuariosfrm usuariosfrm = new Usuariosfrm();
            usuariosfrm.Show();

        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
