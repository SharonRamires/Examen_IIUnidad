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
    public partial class TicketForm : Form
    {
        public TicketForm()
        {
            InitializeComponent();
        }

        Soporte soporte = null;

        private async void tipotextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                SoporteDatos soporteDatos = new SoporteDatos();
                soporte = new Soporte();
                soporte = await soporteDatos.GetDeTipo(tipotextBox.Text);

                if (soporte.Tipo == soporte.Tipo)
                {
                    solicitudtextBox.Text = soporte.Descripcion;
                    respuestatextBox.Text = soporte.Respuesta;
                    //preciotextBox.Text = soporte.Precio;
                }
            }
        }
    }
}
