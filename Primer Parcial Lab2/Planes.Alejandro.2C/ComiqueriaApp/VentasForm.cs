using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComiqueriaLogic;

namespace ComiqueriaApp
{
    public partial class VentasForm : Form
    {
        private Producto productoSeleccionado;
        private Comiqueria comiqueria;

        public VentasForm()
        {
            InitializeComponent();
        }

        public VentasForm(Comiqueria comiqueria, Producto producto):this()
        {
            this.productoSeleccionado = producto;
            this.comiqueria = comiqueria;
        }

        private void VentasForm_Load(object sender, EventArgs e)
        {
            this.lblDescripcion.Text = this.productoSeleccionado.Descripcion;
            this.lblPrecioFinal.Text = "Precio Final: $"+this.productoSeleccionado.Precio;
        }

        private void numericUpDownCantidad_ValueChanged(object sender, EventArgs e)
        {
            this.lblPrecioFinal.Text = "Precio Final: $" + Venta.CalcularPrecioFinal(productoSeleccionado.Precio,(int)numericUpDownCantidad.Value);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            if (numericUpDownCantidad.Value > comiqueria[(Guid)productoSeleccionado].Stock)
            {
                MessageBox.Show("Se superó el stock disponible", "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                comiqueria.Vender(productoSeleccionado, (int)numericUpDownCantidad.Value);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
