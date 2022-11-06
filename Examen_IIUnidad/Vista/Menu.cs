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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void lISTADEUSUARIOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UsuariosForm usuariosForm = new UsuariosForm();
            usuariosForm.Show();
        }

        private void lISTADESOPORTESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SoporteForm soporteform = new SoporteForm();
            soporteform.Show();
        }

        private void gENERARTICKETToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TicketForm ticketForm = new TicketForm();
            ticketForm.Show();
        }
    }
}
