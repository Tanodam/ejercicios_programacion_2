using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_28
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] texto;

            texto = lblTexto.Text.Split(' ');
            Diccionario.Clear();

            foreach(string palabra in texto)
            {
                Diccionario.SetValue(palabra);
            }

            MessageBox.Show(Diccionario.GetValues(3));
        }
    }
}
