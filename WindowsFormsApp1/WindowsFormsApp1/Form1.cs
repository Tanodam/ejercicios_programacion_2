using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnMensaje_Click(object sender, EventArgs e)
        {
            txtNombre.Hide();
            lblMensaje.Text = "Hola " + txtNombre.Text;
            lblMensaje.Width = 100; 
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblMensaje.Text = "";
        }

        private void txtNombre_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
        }
    }
}
