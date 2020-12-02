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
    public partial class Formsistemas : Form
    {
        public int SistemaSeleccionado = 0;
        public Formsistemas()
        {
            InitializeComponent();
            this.FormClosing += Form1_FormClosing;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();

        }

        private void BotonComercial_Click(object sender, EventArgs e)
        {
            BotonComercial.Enabled = false;
            BotonAdminpaq.Enabled = false;
            BotonFacturaElectronica.Enabled = false;
            botonDesarrollosIngenia.Enabled = false;
            SistemaSeleccionado = 1;
            FuncionesComercial.IniciaConexionComercial();
            FormEmpresas formEmpresas = new FormEmpresas(SistemaSeleccionado);
            formEmpresas.Show();
            this.Hide();


        }

        private void BotonAdminpaq_Click(object sender, EventArgs e)
        {
            BotonComercial.Enabled = false;
            BotonAdminpaq.Enabled = false;
            BotonFacturaElectronica.Enabled = false;
            botonDesarrollosIngenia.Enabled = false;
            SistemaSeleccionado = 2;
            FuncionesAdminpaq.IniciaConexionAdminpaq();
            FormEmpresas formEmpresas = new FormEmpresas(SistemaSeleccionado);
        

            formEmpresas.Show();
            this.Hide();

        }

        private void botonDesarrollosIngenia_Click(object sender, EventArgs e)
        {
            BotonComercial.Enabled = false;
            BotonAdminpaq.Enabled = false;
            BotonFacturaElectronica.Enabled = false;
            botonDesarrollosIngenia.Enabled = false;
       
            //Desa

        }

      
    }
}
