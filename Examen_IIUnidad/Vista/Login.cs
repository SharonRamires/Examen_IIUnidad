using Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Vista
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (usuarioTextBox.Text == String.Empty)
            {
                errorProvider1.SetError(usuarioTextBox, "Ingrese un usuario");
                usuarioTextBox.Focus();
                return;
            }
            errorProvider1.Clear();

            if (clavetextBox.Text == string.Empty)
            {
                errorProvider1.SetError(clavetextBox, "Ingrese una clave");
                clavetextBox.Focus();
                return;
            }
            errorProvider1.Clear();

            UsuarioDatos UserDatos = new UsuarioDatos();

            bool valido = await UserDatos.LoginAsync(usuarioTextBox.Text, clavetextBox.Text);

            if (valido)
            {
                Menu Formulario = new Menu();
                Hide();
                Formulario.Show();
            }
            else
            {
                MessageBox.Show("Datos de usuario incorrectos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
