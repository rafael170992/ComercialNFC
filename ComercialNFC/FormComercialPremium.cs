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
    public partial class FormComercialPremium : Form
    {
        public FormComercialPremium()
        {
            InitializeComponent();
            this.FormClosing += Form1_FormClosing;
        }

        private void FormComercialPremium_Load(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            FuncionesComercial.CerrarEmpresa();
            FuncionesComercial.TeminaConexionComercial();
            Application.Exit();

        }

    }
}
