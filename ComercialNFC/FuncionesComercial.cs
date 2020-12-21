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

        public static void AltaCliente()
        {
            int errorAltaCliente = 0;
            int idCliente = 0;
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
