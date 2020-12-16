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


        public void AbrirForms<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            formulario = panelDeControl.Controls.OfType<MiForm>().FirstOrDefault();
            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                panelDeControl.Controls.Add(formulario);
                panelDeControl.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
            }
            else
            {
                formulario.BringToFront();
            }
        }

    }
}
