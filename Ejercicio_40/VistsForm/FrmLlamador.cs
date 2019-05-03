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
  public partial class FrmLlamador : Form
  {
    private Centralita centralita;
    private Llamada llamada;
    private string numero;

    public Centralita Centralita
    {
      get
      {
        return this.centralita;
      }
    }

    public FrmLlamador()
    {
      InitializeComponent();
    }

    public FrmLlamador(Centralita central) : this()
    {
      this.centralita = central;
    }

    private void FrmLlamador_Load(object sender, EventArgs e)
    {
      this.numero = "";
    }

    private void FrmLlamador_Click(object sender, EventArgs e)
    {
      txtDestino.Text = "";
      txtOrigen.Text = "";
    }

    private void botonUno_Click(object sender, EventArgs e)
    {
      this.numero += "1";
      txtDestino.Text = numero;
    }

    private void botonDos_Click(object sender, EventArgs e)
    {
      this.numero += "2";
      txtDestino.Text = numero;
    }

    private void botonTres_Click(object sender, EventArgs e)
    {
      this.numero += "3";
      txtDestino.Text = numero;
    }

    private void botonCuatro_Click(object sender, EventArgs e)
    {
      this.numero += "4";
      txtDestino.Text = numero;
    }

    private void botonCinco_Click(object sender, EventArgs e)
    {
      this.numero += "5";
      txtDestino.Text = numero;
    }

    private void botonSeis_Click(object sender, EventArgs e)
    {
      this.numero += "6";
      txtDestino.Text = numero;
    }

    private void botonSiete_Click(object sender, EventArgs e)
    {
      this.numero += "7";
      txtDestino.Text = numero;
    }

    private void botonOcho_Click(object sender, EventArgs e)
    {
      this.numero += "8";
      txtDestino.Text = numero;
    }

    private void botonNueve_Click(object sender, EventArgs e)
    {
      this.numero += "9";
      txtDestino.Text = numero;
    }

    private void botonCero_Click(object sender, EventArgs e)
    {
      this.numero += "0";
      txtDestino.Text = numero;
    }

    private void btnAsterisco_Click(object sender, EventArgs e)
    {
      this.numero += "*";
      txtDestino.Text = numero;
    }

    private void btnNumeral_Click(object sender, EventArgs e)
    {
      this.numero += "#";
      txtDestino.Text = numero;
    }

    private void txtDestino_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.Enter && txtDestino.Text != "")
      {
        if(txtDestino.Text[0] != '#')
        {
          cmbFranjaHoraria.H
        }
      }
    }
  }
}
