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
            String textValues = "";
            KeyValuePair<string, int> auxiliar;

            string[] texto;

            texto = lblTexto.Text.Split(' ');

            foreach(string palabra in texto)
            {
                Diccionario.SetValue(palabra);
            }

            for (int i=0; i < 3;i++)
            {
                auxiliar = Diccionario.diccionario.Max();
                Diccionario.diccionario.Remove(auxiliar.Key);
                textValues += "\n"+auxiliar.ToString();
            }
            MessageBox.Show(textValues);
        }

    }
}
