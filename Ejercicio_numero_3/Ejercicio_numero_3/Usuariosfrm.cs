using Base_Datos.Accesos;
using Base_Datos.Atributos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_numero_3
{
    public partial class Usuariosfrm : Form
    {
        public Usuariosfrm()
        {
            InitializeComponent();
        }

        UsuariosBDA usuariosBDA = new UsuariosBDA();
        string operacion = string.Empty;
        Usuario user = new Usuario();
        private void Usuariosfrm_Load(object sender, EventArgs e)
        {
            ListarUsuarios();
        }
        private void ListarUsuarios()
        {
            UsuariosDataGridView.DataSource = usuariosBDA.ListarUsuarios();
        }
        private void HabilitarControles()
        {
            CodigoTextBox.Enabled = true;
            NombreTextBox.Enabled = true;
            IdentidadTextBox.Enabled = true;
            RolUsuarioComboBox.Enabled = true;
            GeneroComboBox.Enabled = true;
            ContraseñaTextBox.Enabled = true;
            EdadTextBox.Enabled = true;

            NuevoButton.Enabled = false;
            EditarButton.Enabled = true;
            GuardarButton.Enabled = true;
            CancelarButton.Enabled = true;
        }
        private void DesabilitarControles()
        {
            CodigoTextBox.Enabled = false;
            NombreTextBox.Enabled = false;
            IdentidadTextBox.Enabled = false;
            RolUsuarioComboBox.Enabled = false;
            GeneroComboBox.Enabled = false;
            ContraseñaTextBox.Enabled = false;
            EdadTextBox.Enabled = false;

            NuevoButton.Enabled = true;
            EditarButton.Enabled = false;
            GuardarButton.Enabled = false;
            CancelarButton.Enabled = false;
        }
        private void LimpiarControles()
        {
            CodigoTextBox.Text = "";
            NombreTextBox.Text = "";
            IdentidadTextBox.Text = "";
            RolUsuarioComboBox.Text = "";
            GeneroComboBox.Text = "";
            ContraseñaTextBox.Text = "";
            EdadTextBox.Text = "";
        }
        private void NuevoButton_Click(object sender, EventArgs e)
        {
            HabilitarControles();
            operacion = "Nuevo";
        }

        private void EditarButton_Click(object sender, EventArgs e)
        {
            operacion = "Modificar";

            if (UsuariosDataGridView.SelectedRows.Count > 0)
            {
                CodigoTextBox.Text = UsuariosDataGridView.CurrentRow.Cells["Codigo"].Value.ToString();
                NombreTextBox.Text = UsuariosDataGridView.CurrentRow.Cells["Nombre"].Value.ToString();
                IdentidadTextBox.Text = UsuariosDataGridView.CurrentRow.Cells["Identidad"].Value.ToString();
                RolUsuarioComboBox.Text = UsuariosDataGridView.CurrentRow.Cells["RolUsuario"].Value.ToString();
                GeneroComboBox.Text = UsuariosDataGridView.CurrentRow.Cells["Genero"].Value.ToString();
                ContraseñaTextBox.Text = UsuariosDataGridView.CurrentRow.Cells["Contraseña"].Value.ToString();
                EdadTextBox.Text = UsuariosDataGridView.CurrentRow.Cells["Edad"].Value.ToString();
                HabilitarControles();
            }
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            user.CodigoU = CodigoTextBox.Text;
            user.Nombre = NombreTextBox.Text;
            user.Identidad = IdentidadTextBox.Text;
            user.RolUsuario = RolUsuarioComboBox.Text;
            user.Genero = GeneroComboBox.Text;
            user.Contraseña = ContraseñaTextBox.Text;
            user.Edad = Convert.ToInt32(EdadTextBox.Text);

            if (operacion == "Nuevo")
            {
                bool Nuevo = usuariosBDA.NuevoUsuario(user);

                if (Nuevo)
                {
                    MessageBox.Show("Usuario Creado");
                    ListarUsuarios();
                    LimpiarControles();
                    DesabilitarControles();
                }
                else
                {
                    MessageBox.Show("Usuario no se pudo Crear");
                }
            }
            else if (operacion == "Modificar")
            {
                bool modifico = usuariosBDA.EditarUsuario(user);
                if (modifico)
                {
                    MessageBox.Show("Usuario Modificado");
                    ListarUsuarios();
                    LimpiarControles();
                    DesabilitarControles();
                }
                else
                {
                    MessageBox.Show("Usuario no se pudo Modificar");
                }
            }
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            if (UsuariosDataGridView.SelectedRows.Count > 0)
            {
                bool elimino = usuariosBDA.EliminarUsuario(UsuariosDataGridView.CurrentRow.Cells["CodigoU"].Value.ToString());
                if (elimino)
                {
                    MessageBox.Show("Usuario Eliminado");
                    ListarUsuarios();
                }
                else
                {
                    MessageBox.Show("Usuario no se pudo Eliminar");
                }

            }
        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            DesabilitarControles();
            LimpiarControles();
        }
    }
}
