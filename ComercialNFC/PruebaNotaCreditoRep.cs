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
    public partial class PruebaNotaCreditoRep : Form
    {

        double folio = 0;
        string conceptoTimbrado = "";
        public PruebaNotaCreditoRep()
        {
            InitializeComponent();
        }

        private void PruebaNotaCreditoRep_Load(object sender, EventArgs e)
        {

        }


        private void GenerarDocumento_Click(object sender, EventArgs e)
        {
            CrearDocumentos();
        }

        private void TimbrarDocumento_Click(object sender, EventArgs e)
        {
            EmitirDocumento();
        }

        private void GenerarDocumentoNotaDeCredito_Click(object sender, EventArgs e)
        {
            CreaNotaDeCredito();
        }

        private void TimbrarNotaDeCredito_Click(object sender, EventArgs e)
        {
            EmitirDocumento();
        }

        private void GenerardocumentoElectronicoDePago_Click(object sender, EventArgs e)
        {
            CreaReciboElectronicoDePago();
        }

        private void TimbrarReciboElectronicoDePago_Click(object sender, EventArgs e)
        {
            EmitirDocumento();
        }


        public void CrearDocumentos()

        {
            int errorDocumento, errorMovimiento = 0;
            int idDocumento = 0;
            int idMovimiento = 0;

            StringBuilder serie = new StringBuilder("");
            MgwServicios.fSiguienteFolio(CodigoConcepto.Text, serie, ref folio);
            MgwServicios.tDocumento documento = new MgwServicios.tDocumento();

            documento.aFolio = folio;
            documento.aFecha = DateTime.Now.ToString("MM/dd/yyyy");
            documento.aSerie = serie.ToString();
            documento.aCodigoCteProv = CodigoCliente.Text;
            documento.aNumMoneda = 1;
            documento.aAfecta = 1;
      
         
            documento.aCodConcepto = CodigoConcepto.Text;
            conceptoTimbrado = CodigoConcepto.Text;

            errorDocumento = MgwServicios.fAltaDocumento(ref idDocumento, ref documento);

            if (errorDocumento == 0)
            {

                MgwServicios.fEditarDocumento();
                errorDocumento = MgwServicios.fSetDatoDocumento("COBSERVACIONES", "esta es mi observacíon");
               // errorDocumento = MgwServicios.fSetDatoDocumento("CMETODOPAG", "99");
               // errorDocumento = MgwServicios.fSetDatoDocumento("CCANTPARCI", "01");
                MgwServicios.fGuardaDocumento();

                // for (int i = 0; i < 500; i++)
                // {

                MgwServicios.tMovimiento movimiento = new MgwServicios.tMovimiento();
                movimiento.aCodProdSer = CodigoProducto.Text;
                movimiento.aPrecio = Convert.ToDouble(Precio.Text);
                movimiento.aCodAlmacen = "1";
                movimiento.aCosto = 30;
               // movimiento.aUnidades = 1;
                movimiento.aCodClasificacion = "31";
                
                movimiento.aUnidades = double.Parse(Unidades.Text);

                errorMovimiento = MgwServicios.fAltaMovimiento(idDocumento, ref idMovimiento, ref movimiento);

                if (errorMovimiento == 0)
                {

                    MgwServicios.fEditarMovimiento();
                    errorDocumento = MgwServicios.fSetDatoMovimiento("CIDALMACEN", "2");
                    MgwServicios.fGuardaMovimiento();
                    MessageBox.Show("Documento y movimiento creado con exito");
                    MgwServicios.fDesbloqueaDocumento();

                }
                else
                {
                    MessageBox.Show("Se genero el siguiente codigo de error:" + errorMovimiento);

                }

                //  }
                //}

            }
            else
            {
                MessageBox.Show("Se genero el siguiente error con codigo: " + errorDocumento);
            }

        }// Fin metodo CrearDocumentos

        
        public void EmitirDocumento()
        {
            int errorTimbrado;
            double FolioTimbrar = folio;
            errorTimbrado = MgwServicios.fEmitirDocumento(conceptoTimbrado, "", FolioTimbrar, "12345678a", "");

            if (errorTimbrado == 0)
            {
                MessageBox.Show("El documento se timbro con exito");
            }
            else
            {
                MgwServicios.rError(errorTimbrado);
            }

        }


        public void CreaNotaDeCredito()
        {

            folio = 0;
            MgwServicios.tDocumento DoctoCargoAbono = new MgwServicios.tDocumento();
            MgwServicios.RegLlaveDoc saldar = new MgwServicios.RegLlaveDoc();
            MgwServicios.RegLlaveDoc pago = new MgwServicios.RegLlaveDoc();
            StringBuilder serie = new StringBuilder("");


            //var concepto = "8";
            var concepto = ConceptoNotaCredito.Text;
            conceptoTimbrado = ConceptoNotaCredito.Text;
            MgwServicios.lError = MgwServicios.fSiguienteFolio(concepto, serie, ref folio);

            DoctoCargoAbono.aCodConcepto = concepto;
            DoctoCargoAbono.aFolio = folio;
            DoctoCargoAbono.aSerie = "";

            DoctoCargoAbono.aFecha = DateTime.Today.ToString("MM/dd/yyyy");
            //DoctoCargoAbono.aCodigoCteProv = "100";
            DoctoCargoAbono.aCodigoCteProv = ClienteProveedorNotaCredito.Text;
            DoctoCargoAbono.aTipoCambio = 1;
            DoctoCargoAbono.aNumMoneda = 1;
            //DoctoCargoAbono.aImporte = 10; //Importe total del documento de pago
            DoctoCargoAbono.aImporte = Double.Parse(ImporteNotaDeCredito.Text);
            DoctoCargoAbono.aReferencia = "DOCTO SDK";

            MgwServicios.lError = MgwServicios.fAltaDocumentoCargoAbono(ref DoctoCargoAbono);
            if (MgwServicios.lError != 0)
            {
                
                MgwServicios.rError(MgwServicios.lError);
            }
            else
            {
                MessageBox.Show("Documento creado");


                //saldar.aCodConcepto = "4";//codigo de concepto del documento a saldar
                saldar.aCodConcepto = ConceptoPagarNotaDeCredito.Text;

                saldar.aSerie = "";//Serie del documento a saldar
                                   //saldar.folio = 2;//Folio del documento a saldar
                saldar.folio = Double.Parse(FolioPagarNotaDeCredito.Text);

                pago.aCodConcepto = concepto;//Concepto del documento de pago
                pago.aSerie = "";//Serie del documento de pago 
                pago.folio = folio;//Folio del documento de pago



                //Saldamos la primer factura
                MgwServicios.lError = MgwServicios.fSaldarDocumento(ref saldar, ref pago, Double.Parse(ImportePagarNotaDeCredito.Text), 1,
                    DateTime.Now.ToString("MM/dd/yyyy"));

                if (MgwServicios.lError != 0)
                {
                    MgwServicios.rError(MgwServicios.lError);
                }
                else
                {
                    MessageBox.Show("Documento saldado");


                }

            }

        }


        public void CreaReciboElectronicoDePago()
        {
            folio = 0;
            int lerror = 0;
            lerror = MgwServicios.fCuentaBancariaEmpresaDoctos("1234567890123456");
            MgwServicios.tDocumento DoctoCargoAbono = new MgwServicios.tDocumento();
            MgwServicios.RegLlaveDoc saldar = new MgwServicios.RegLlaveDoc();
            MgwServicios.RegLlaveDoc pago = new MgwServicios.RegLlaveDoc();

            StringBuilder serie = new StringBuilder("");
            //var concepto = "10";
            var concepto = ConceptoReciboElectronicoPago.Text;
            conceptoTimbrado = ConceptoReciboElectronicoPago.Text;
            lerror = MgwServicios.fSiguienteFolio(concepto, serie, ref folio);

            DoctoCargoAbono.aCodConcepto = concepto;
            DoctoCargoAbono.aFolio = folio;
            DoctoCargoAbono.aSerie = "";
            DoctoCargoAbono.aFecha = DateTime.Today.ToString("MM/dd/yyyy");
            //DoctoCargoAbono.aCodigoCteProv = "100";
            DoctoCargoAbono.aCodigoCteProv = CodigoClienteProveedorReciboElectronicoDePago.Text;
            DoctoCargoAbono.aTipoCambio = 1;
            DoctoCargoAbono.aNumMoneda = 1;
            //DoctoCargoAbono.aImporte = 3979.09;
            DoctoCargoAbono.aImporte = Double.Parse(ImporteReciboElectronicoPago.Text);
            DoctoCargoAbono.aReferencia = "DOCTO SDK";

            lerror = MgwServicios.fAltaDocumentoCargoAbono(ref DoctoCargoAbono);
            if (lerror != 0)
            {
                MessageBox.Show("se genero el siguiente error" + lerror);

            }
            else
            {
                MessageBox.Show("Documento creado");
                MgwServicios.fEditarDocumento();
                lerror = MgwServicios.fSetDatoDocumento("CMETODOPAG", "01");
                lerror = MgwServicios.fSetDatoDocumento("CCANTPARCI", "1");
                lerror = MgwServicios.fSetDatoDocumento("CNUMPARCIA", "1");
                lerror = MgwServicios.fSetDatoDocumento("CUSUBAN03", "17:10:00");
                lerror = MgwServicios.fSetDatoDocumento("CIDMONEDCA", "2");

                lerror = MgwServicios.fGuardaDocumento();


                //saldar.aCodConcepto = "4";
                saldar.aCodConcepto = ConceptoDeDocumentoPagarReciboElectronicoDePago.Text;

                saldar.aSerie = "";

                //saldar.folio = 2;
                saldar.folio = Double.Parse(FolioDocumentoPagarReciboElectronicoDePago.Text);


                pago.aCodConcepto = concepto;
                pago.aSerie = "";
                pago.folio = folio;

                lerror = MgwServicios.fSaldarDocumento(ref saldar, ref pago, Double.Parse(ImportaPagarDocumentoReciboElectronicoDePago.Text), 1, DateTime.Now.ToString("MM/dd/yyyy"));


                if (lerror != 0)

                {
                    MgwServicios.rError(lerror);
                   // MessageBox.Show("se genero un error " + lerror);
                }
                else
                {

                    MessageBox.Show("Documento Creado con éxito");


                    //lerror = MgwServicios.fEmitirDocumento(concepto, "", folio, "12345678a", "");

                    //if (lerror != 0)
                    //{
                    //    MessageBox.Show("se genero el error" + lerror);
                    //}
                    //else
                    //{
                    //    MessageBox.Show("Documento timbrado");
                    //}
                }

            }
        }

    
    }
}
