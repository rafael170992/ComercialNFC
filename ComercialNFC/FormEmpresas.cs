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
    public partial class FormEmpresas : Form
    {
        int SeleccionarSistema = 0;
        public FormEmpresas(int Sistema)
        {
            InitializeComponent();
            this.FormClosing += Form1_FormClosing;
            SeleccionarSistema = Sistema;


        }

        private void FormComercial_Load(object sender, EventArgs e)
        {
            switch (SeleccionarSistema)
            {
                case 1:

                    FuncionesComercial funcionesComercial = new FuncionesComercial();

                    foreach (var empresas in funcionesComercial.InformaciónEmpresas())
                    {
                        GridEmpresas.Rows.Add(empresas.nombreDeEmpresa, empresas.rutaDeEmpresa);
                    }

                    break;

                case 2:

                    FuncionesAdminpaq funcionesAdminpaq = new FuncionesAdminpaq();

                    foreach (var empresas in funcionesAdminpaq.InformaciónEmpresas())
                    {
                        GridEmpresas.Rows.Add(empresas.nombreDeEmpresa, empresas.rutaDeEmpresa);
                    }

                    break;


                default:
                    break;
            }

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch (SeleccionarSistema)
            {
                case 1:
                    FuncionesComercial.TeminaConexionComercial();
                    Application.Exit();

                    break;

                case 2:
                    FuncionesAdminpaq.TeminaConexionAdminpaq();
                    Application.Exit();

                    break;

                default:
                    break;


            }

        }

        private void GridEmpresas_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {


            switch (SeleccionarSistema)
            {

                case 1:
                    string nombreEmpresaComercial = "";
                    nombreEmpresaComercial = GridEmpresas.Rows[e.RowIndex].Cells["BaseDeDatos"].Value.ToString();
                    FuncionesComercial funcionesComercial = new FuncionesComercial();


                    if (funcionesComercial.AbrirEmpresa(nombreEmpresaComercial) == 0)
                    {
                        FormComercialPremium formComercialPremium = new FormComercialPremium();
                        formComercialPremium.Show();
                        this.Hide();

                    }

                    break;

                case 2:
                    string nombreEmpresaAdminpaq = "";
                    nombreEmpresaAdminpaq = GridEmpresas.Rows[e.RowIndex].Cells["BaseDeDatos"].Value.ToString();
                    FuncionesAdminpaq funcionesAdminpaq = new FuncionesAdminpaq();


                    if (funcionesAdminpaq.AbrirEmpresa(nombreEmpresaAdminpaq) == 0)
                    {
                        FormAdminpaq formAdminpaq = new FormAdminpaq();
                        formAdminpaq.Show();
                        this.Hide();

                    }

                    break;


                default:
                    break;
            }

        }
    }
}
