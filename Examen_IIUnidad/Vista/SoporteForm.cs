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
    public partial class SoporteForm : Form
    {
        public SoporteForm()
        {
            InitializeComponent();
        }

        SoporteDatos sopDatos = new SoporteDatos();
        Soporte soporte = new Soporte();
        string TipoOperacion;

        private void SoporteForm_Load(object sender, EventArgs e)
        {
            LlenarSoporte();
        }

        private async void LlenarSoporte()
        {
            soportesdataGridView.DataSource = await sopDatos.DevolverListaAsync();
        }

        private void HabilitarControles()
        {
            tipotextBox.Enabled = true;
            descripciontextBox.Enabled = true;
            soluciontextBox.Enabled = true;
            preciotextBox.Enabled = true;
        }

        private void LimpiarControles()
        {
            tipotextBox.Clear();
            descripciontextBox.Clear();
            soluciontextBox.Clear();
            preciotextBox.Clear();
        }
        private void desabilitarControles()
        {
            tipotextBox.Enabled = false;
            descripciontextBox.Enabled = false;
            soluciontextBox.Enabled = false;
            preciotextBox.Enabled = false;
        }

        private void nuevobutton_Click(object sender, EventArgs e)
        {
            TipoOperacion = "Nuevo";
            HabilitarControles();
        }

        private async void guardarbutton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tipotextBox.Text))
            {
                errorProvider1.SetError(tipotextBox, "Ingrese el tipo de soporte");
                tipotextBox.Focus();
                return;
            }
            if (string.IsNullOrEmpty(descripciontextBox.Text))
            {
                errorProvider1.SetError(descripciontextBox, "Ingrese una descripcion");
                descripciontextBox.Focus();
                return;
            }
            if (string.IsNullOrEmpty(soluciontextBox.Text))
            {
                errorProvider1.SetError(soluciontextBox, "Ingrese una Solucion");
                soluciontextBox.Focus();
                return;
            }
            if (string.IsNullOrEmpty(preciotextBox.Text))
            {
                errorProvider1.SetError(preciotextBox, "Ingrese un precio");
                preciotextBox.Focus();
                return;
            }

            soporte.Tipo = tipotextBox.Text;
            soporte.Descripcion = descripciontextBox.Text;
            soporte.Respuesta = soluciontextBox.Text;
            soporte.Precio = Convert.ToDecimal(preciotextBox.Text);

            if (TipoOperacion == "Nuevo")
            {
                bool inserto = await sopDatos.InsertarAsync(soporte);
                if (inserto)
                {
                    LlenarSoporte();
                    LimpiarControles();
                    desabilitarControles();
                    MessageBox.Show("Soporte Guardado", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Soporte no se pudo guardar", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (TipoOperacion == "Modifico")
            {
                bool modifico = await sopDatos.ActualizarAsync(soporte);
                if (modifico)
                {
                    LlenarSoporte();
                    LimpiarControles();
                    desabilitarControles();
                    MessageBox.Show("Soporte Guardado", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Soporte no se pudo guardar", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void modificarbutton_Click(object sender, EventArgs e)
        {
            if (soportesdataGridView.SelectedRows.Count > 0)
            {
                TipoOperacion = "Modificar";
                HabilitarControles();
                tipotextBox.ReadOnly = true;
                tipotextBox.Text = soportesdataGridView.CurrentRow.Cells["Tipo"].Value.ToString();
                descripciontextBox.Text = soportesdataGridView.CurrentRow.Cells["Descripcion"].Value.ToString();
                soluciontextBox.Text = soportesdataGridView.CurrentRow.Cells["Respuesta"].Value.ToString();
                preciotextBox.Text = soportesdataGridView.CurrentRow.Cells["Precio"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un registro", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private async void eliminarbutton_Click(object sender, EventArgs e)
        {
            if (soportesdataGridView.SelectedRows.Count > 0)
            {
                bool elimino = await sopDatos.EliminarAsync(soportesdataGridView.CurrentRow.Cells["Tipo"].Value.ToString());
                if (elimino)
                {
                    LlenarSoporte();
                    MessageBox.Show("Soporte Eliminado", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Soporte no se pudo eliminar", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un registro", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}