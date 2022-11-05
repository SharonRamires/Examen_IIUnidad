using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class UsuariosForm : Form
    {
        public UsuariosForm()
        {
            InitializeComponent();
        }

        UsuarioDatos userDatos = new UsuarioDatos();
        string tipoOperacion = string.Empty;
        Usuario user;

        private void UsuariosForm_Load(object sender, EventArgs e)
        {
            LlenarDataGrid();
        }

        private async void LlenarDataGrid()
        {
            usuariosdataGridView.DataSource = await userDatos.DevolverListaAsync();
        }

        private void nuevobutton_Click(object sender, EventArgs e)
        {
            HabilitarControles();
            tipoOperacion = "Nuevo";
        }

        private void HabilitarControles()  //HABILITAR LOS CONTROLES
        {
            codigotextBox.Enabled = true;
            nombretextBox.Enabled = true;
            clavetextBox.Enabled = true;
            rolcomboBox.Enabled = true;
            estaactivocheckBox.Enabled = true;
        }

        private void DesabilitarControles()   //DESABILITAR LOS CONTROLES
        {
            codigotextBox.Enabled = false;
            nombretextBox.Enabled = false;
            clavetextBox.Enabled = false;
            rolcomboBox.Enabled = false;
            estaactivocheckBox.Enabled = false;
        }

        private void cancelarbutton_Click(object sender, EventArgs e)
        {
            DesabilitarControles();
            LimpiarControles();
        }

        private void LimpiarControles()  //LIMPIAR LOS CONTROLES
        {
            codigotextBox.Clear();
            nombretextBox.Clear();
            clavetextBox.Clear();
            rolcomboBox.Text = string.Empty;
            estaactivocheckBox.Checked = false;
        }

        private void modificarbutton_Click(object sender, EventArgs e)
        {
            tipoOperacion = "Modificar";
        }

        private async void guardarbutton_Click(object sender, EventArgs e)
        {
            if (tipoOperacion == "Nuevo")
            {
                user = new Usuario();

                if (codigotextBox.Text == "")
                {
                    errorProvider1.SetError(codigotextBox, "Ingrese un codigo");
                    codigotextBox.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(nombretextBox.Text))
                {
                    errorProvider1.SetError(nombretextBox, "Ingrese un nombre");
                    nombretextBox.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(clavetextBox.Text))
                {
                    errorProvider1.SetError(clavetextBox, "Ingrese una clave");
                    clavetextBox.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(rolcomboBox.Text))
                {
                    errorProvider1.SetError(rolcomboBox, "Seleccione un rol");
                    rolcomboBox.Focus();
                    return;
                }

                //METODO PARA INSERTAR EL REGISTRO
                user.Codigo = codigotextBox.Text.ToUpper(); 
                user.Nombre = nombretextBox.Text;
                user.Clave = clavetextBox.Text;
                user.Rol = rolcomboBox.Text;
                user.EstaActivo = estaactivocheckBox.Checked;

                bool inserto = await userDatos.InsertarAsync(user);

                if (inserto)
                {
                    LlenarDataGrid();
                    LimpiarControles();
                    DesabilitarControles();
                    MessageBox.Show("Usuario Guardado", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Usuario no se pudo guardar", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (tipoOperacion == "Modificar")
            {
                if (codigotextBox.Text == "")
                {
                    errorProvider1.SetError(codigotextBox, "Ingrese un codigo");
                    codigotextBox.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(nombretextBox.Text))
                {
                    errorProvider1.SetError(nombretextBox, "Ingrese un nombre");
                    nombretextBox.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(clavetextBox.Text))
                {
                    errorProvider1.SetError(clavetextBox, "Ingrese una clave");
                    clavetextBox.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(rolcomboBox.Text))
                {
                    errorProvider1.SetError(rolcomboBox, "Seleccione un rol");
                    rolcomboBox.Focus();
                    return;
                }

                user.Codigo = codigotextBox.Text.ToUpper();
                user.Nombre = nombretextBox.Text;
                user.Clave = clavetextBox.Text;
                user.Rol = rolcomboBox.Text;
                user.EstaActivo = estaactivocheckBox.Checked;

                bool modifico = await userDatos.ActualizarAsync(user);

                if (modifico)
                {
                    LlenarDataGrid();
                    LimpiarControles();
                    DesabilitarControles();
                    MessageBox.Show("Usuario Guardado", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Usuario no se pudo guardar", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private async void eliminarbutton_Click(object sender, EventArgs e)
        {
            if (usuariosdataGridView.SelectedRows.Count > 0)
            {
                bool elimino = await userDatos.EliminarAsync(usuariosdataGridView.CurrentRow.Cells["codigo"].Value.ToString());

                if (elimino)
                {
                    LlenarDataGrid();
                    LimpiarControles();
                    DesabilitarControles();
                    MessageBox.Show("Usuario Eliminado", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Usuario no se pudo eliminar", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
