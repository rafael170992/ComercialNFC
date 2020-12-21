using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComercialNFC
{
    public partial class FormAltaCliente : Form
    {
        public FormAltaCliente()
        {
            InitializeComponent();
        }






        #region GENERAR MARCA DE AGUA EN TEXTBOX
        private void CodigoCliente_Enter(object sender, EventArgs e)
        {
            if (CodigoCliente.Text == "Código del cliente")
            {
                CodigoCliente.Text = "";
                CodigoCliente.ForeColor = Color.Black;
            }
        }

        private void CodigoCliente_Leave(object sender, EventArgs e)
        {

            if (CodigoCliente.Text == "")
            {
                CodigoCliente.Text = "Código del cliente";
                CodigoCliente.ForeColor = Color.Silver;
            }

        }

        private void NombreDelCliente_Enter(object sender, EventArgs e)
        {
            if (NombreDelCliente.Text == "Nombre del cliente")
            {
                NombreDelCliente.Text = "";
                NombreDelCliente.ForeColor = Color.Black;
            }
        }

        private void NombreDelCliente_Leave(object sender, EventArgs e)
        {
            if (NombreDelCliente.Text == "")
            {
                NombreDelCliente.Text = "Nombre del cliente";
                NombreDelCliente.ForeColor = Color.Silver;
            }
        }

        private void NombreLargoDelCliente_Enter(object sender, EventArgs e)
        {
            if (NombreLargoDelCliente.Text == "Nombre largo del cliente")
            {
                NombreLargoDelCliente.Text = "";
                NombreLargoDelCliente.ForeColor = Color.Black;
            }
        }

        private void NombreLargoDelCliente_Leave(object sender, EventArgs e)
        {
            if (NombreLargoDelCliente.Text == "")
            {
                NombreLargoDelCliente.Text = "Nombre largo del cliente";
                NombreLargoDelCliente.ForeColor = Color.Silver;
            }
        }
        #endregion

     
    }
}
