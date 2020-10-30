using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComercialNFC
{
    class FuncionesAdminpaq
    {

        public static void IniciaConexionAdminpaq()
        {
            int numeroDeError = 0;
            string sistema = "AdminPAQ";
            string ruta = @"C:\Program Files (x86)\Compacw\AdminPAQ";

            Mgw_SDK.SetCurrentDirectory(ruta);
            numeroDeError = Mgw_SDK.fSetNombrePAQ(sistema);

            if (numeroDeError != 0)
            {
                Mgw_SDK.rError(numeroDeError);
            }
            else
            {

            }

        }
        public static void TeminaConexionAdminpaq()
        {
            Mgw_SDK.fTerminaSDK();

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
                errorListadoEmpresas = Mgw_SDK.fPosSiguienteEmpresa(ref idEmpresas, nombreDeEmpresa, rutaDeEmpresa);

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

            errorAbrirEmpresa = Mgw_SDK.fAbreEmpresa(rutaEmpresa);

            if (errorAbrirEmpresa != 0)
            {

                Mgw_SDK.rError(errorAbrirEmpresa);

            }


            return errorAbrirEmpresa;
        }

        public static void CerrarEmpresaAdminpaq()
        {

            Mgw_SDK.fCierraEmpresa();
        }


    }
}