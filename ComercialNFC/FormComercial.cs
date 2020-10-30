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
    public partial class FormComercial : Form
    {
         
        public FormComercial()
        {
            InitializeComponent();
            this.FormClosing += Form1_FormClosing;
                     
        }

        private void FormComercial_Load(object sender, EventArgs e)
        {

            FuncionesComercial funcionesComercial =  new  FuncionesComercial();

            foreach (var empresas in funcionesComercial.InformaciónEmpresas())
            {
                GridEmpresas.Rows.Add(empresas.nombreDeEmpresa, empresas.rutaDeEmpresa);
            }
                   
             
         }
                
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

            FuncionesComercial.TeminaConexionComercial();
            Application.Exit();

        }

        private void GridEmpresas_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string nombreEmpresa = "";
            nombreEmpresa = GridEmpresas.Rows[e.RowIndex].Cells["BaseDeDatos"].Value.ToString();
            FuncionesComercial funcionesComercial = new FuncionesComercial();
            funcionesComercial.AbrirEmpresa(nombreEmpresa);
        }
    }
}
