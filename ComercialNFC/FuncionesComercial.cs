using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComercialNFC
{
    class FuncionesComercial
    {

        public void AltaCliente(string codigoCliente)
        {
            int errorAltaCliente = 0;
            int idCliente = 0;
            MgwServicios.tCteProv cliente = new MgwServicios.tCteProv();
            errorAltaCliente = BuscarCliente(codigoCliente);
            if (errorAltaCliente != 0)
            {


                //cliente.cCodigoCliente; //Informacion encabezado
                //cliente.cRazonSocial;   //Informacion encabezado
                //cliente.cFechaAlta;     //Informacion encabezado

                //cliente.cRFC;           //Datos de cliente
                //cliente.cDenComercial;  //Datos de cliente
                //cliente.cNombreMoneda;  //Datos de cliente
                //cliente.cCURP;          //Datos de cliente
                //cliente.cRepLegal;      //Datos de cliente

                //cliente.cCodigoValorClasificacionCliente1   //clasificación cliente
                //cliente.cCodigoValorClasificacionCliente2   //clasificación cliente
                //cliente.cCodigoValorClasificacionCliente3   //clasificación cliente
                //cliente.cCodigoValorClasificacionCliente4   //clasificación cliente
                //cliente.cCodigoValorClasificacionCliente5   //clasificación cliente
                //cliente.cCodigoValorClasificacionCliente6   //clasificación cliente

                //cliente.cImpuesto1              //Impuestos y retenciones
                //cliente.cImpuesto2              //Impuestos y retenciones
                //cliente.cImpuesto3              //Impuestos y retenciones
                //cliente.cRetencionCliente1      //Impuestos y retenciones
                //cliente.cRetencionCliente2      //Impuestos y retenciones

                //cliente.cLimiteCreditoCliente   //Límite de crédito
                //cliente.cDiasCreditoCliente     //Límite de crédito
                //cliente.cBanExcederCredito      //Límite de crédito
                
                //cliente.cDescuentoProntoPago    //Descuentos por pronto pago
                //cliente.cDiasProntoPago         //Descuentos por pronto pago


                //cliente.cBanInteresMoratorio    //Intereses moratorios
                
                //cliente.cDiaPago                //Día(s) de pago

                //cliente.cDiasRevision           //Día(s) de revisión

                //cliente.cMensajeria             //Envíos
                //cliente.cCuentaMensajeria       //Envíos

                //cliente.cDiasEmbarqueCliente    //Día(s) de Embarque

                //cliente.cCodigoAlmacen          //Almacén control de consignación

                //cliente.cCodigoAgenteVenta      //Agentes
                //cliente.cCodigoAgenteCobro      //Agentes
                


            }
            else
            {
                MgwServicios.rError(errorAltaCliente);
            }



        }


        public int BuscarCliente(string codigocliente)
        {
            int errorBuscarCliente = 0;
            errorBuscarCliente = MgwServicios.fBuscaCteProv(codigocliente);

            return errorBuscarCliente;
        }




        public static void IniciaConexionComercial()
        {
            int numeroDeError = 0;
            string sistema = "CONTPAQ I COMERCIAL";
            string ruta = @"C:\Program Files (x86)\Compac\COMERCIAL";

            MgwServicios.SetCurrentDirectory(ruta);
            numeroDeError = MgwServicios.fSetNombrePAQ(sistema);

            if (numeroDeError != 0)
            {
                MgwServicios.rError(numeroDeError);
            }
            else
            {
               
            }

        }

        public static void TeminaConexionComercial()
        {
            MgwServicios.fTerminaSDK();

        }

        public List<Empresas> InformaciónEmpresas()
        {

            int errorListadoEmpresas = 0;
            int idEmpresas = 0;
            List<Empresas> ListarEmpresas = new List<Empresas>();
            Empresas empresas;

            do
            {
                StringBuilder nombreDeEmpresa = new StringBuilder(255);
                StringBuilder rutaDeEmpresa = new StringBuilder(255);
                errorListadoEmpresas = MgwServicios.fPosSiguienteEmpresa(ref idEmpresas, nombreDeEmpresa, rutaDeEmpresa);

                if (errorListadoEmpresas != 0) // si es diferente de 0 significa que ya no hay empresas
                {
                    break;
                }
                else
                {

                    empresas = new Empresas();

                    empresas.IdEmpresas = idEmpresas;
                    empresas.RutaDeEmpresa = rutaDeEmpresa;
                    empresas.NombreDeEmpresa = nombreDeEmpresa;
                    ListarEmpresas.Add(empresas);


                }


            } while (errorListadoEmpresas == 0);

            return ListarEmpresas;

        }


        public int AbrirEmpresa(string rutaEmpresa)
        {

            int errorAbrirEmpresa = 0;

          errorAbrirEmpresa = MgwServicios.fAbreEmpresa(rutaEmpresa);
            
            if (errorAbrirEmpresa != 0)
            {
               
                MgwServicios.rError(errorAbrirEmpresa);

            }
         

            return errorAbrirEmpresa;
        }

        public static void CerrarEmpresa() {

            MgwServicios.fCierraEmpresa();
        }


    }
}
