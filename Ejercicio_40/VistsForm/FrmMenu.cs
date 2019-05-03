using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace VistaForm
{
  public partial class FrmCentral : Form
  {
    Centralita centralita = new Centralita("Pepito's Call Center");

    public FrmCentral()
    {
      InitializeComponent();
    }

    private void button4_Click(object sender, EventArgs e)
    {

    }

    private void FrmCentral_Load(object sender, EventArgs e)
    {

    }

    private void btnGenerarLlamada_Click(object sender, EventArgs e)
    {
      FrmLlamador formLlamador = new FrmLlamador(centralita);
      formLlamador.Show();

    }
  }
}
