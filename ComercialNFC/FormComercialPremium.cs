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

        private void altaClienteProToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void pruebaNotaDeCreditoREpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirForms<PruebaNotaCreditoRep>();
            
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



        //private void GenerarDocumento_Click(object sender, EventArgs e)
        //{
        //    int errorDocumento = 0, errorMovimiento = 0, errorMovimientoCapa = 0; //  variables en las cuales se guardan los codigos de errores de las funciones a usar 
        //    int idDocumento = 0;
        //    int idMovimiento = 0;
        //    double folio = 0;
        //    StringBuilder serie = new StringBuilder("");
        //    MgwServicios.fSiguienteFolio("100", serie, ref folio);
        //    MgwServicios.tDocumento documento = new MgwServicios.tDocumento();
        //    documento.aFolio = folio;
        //    documento.aFecha = DateTime.Today.ToString("MM/dd/yyyy");
        //    documento.aSerie = serie.ToString();
        //    documento.aCodigoCteProv = "100";
        //    documento.aNumMoneda = 1;
        //    documento.aAfecta = 1;
        //    documento.aCodConcepto = "100";

        //    errorDocumento = MgwServicios.fAltaDocumento(ref idDocumento, ref documento);

        //    if (errorDocumento == 0)
        //    {

        //        MgwServicios.RegMovimientoCDesctos movimientoCDesctos = new MgwServicios.RegMovimientoCDesctos();

        //        movimientoCDesctos.aCodProdSer = "1000";
        //        movimientoCDesctos.aPrecio = 100;
        //        movimientoCDesctos.aCodAlmacen = "1";
        //        movimientoCDesctos.aCosto = 30;
        //        // movimientoCDesctos.aCodClasificacion = "31";
        //        movimientoCDesctos.aUnidades = 1;

        //        errorMovimiento = MgwServicios.fAltaMovimientoCDesct(idDocumento, ref idMovimiento, ref movimientoCDesctos);

        //        if (errorMovimiento == 0)
        //        {
        //            MgwServicios.tSeriesCapas capasSeries = new MgwServicios.tSeriesCapas();

        //            capasSeries.aFechaPedimento = "10/09/2020";
        //            capasSeries.aPedimento = "10 47 3807 8003832";
        //            capasSeries.aUnidades = 1;

        //            errorMovimientoCapa = MgwServicios.fAltaMovimientoSeriesCapas(idMovimiento, ref capasSeries);
        //            if (errorMovimientoCapa == 0)
        //            {
        //                MessageBox.Show("Documento y movimiento creado con exito");
        //            }
        //            else
        //            {
        //                MessageBox.Show("Se genero el siguiente codigo de error:" + errorMovimientoCapa);

        //            }


        //        }
        //        else
        //        {
        //            MessageBox.Show("Se genero el siguiente codigo de error:" + errorMovimiento);

        //        }


        //    }
        //    else
        //    {
        //        MessageBox.Show("Se genero el siguiente error con codigo: " + errorDocumento);
        //    }
        //}
    }
}
