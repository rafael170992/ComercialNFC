using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;


namespace ComercialNFC
{
    class Mgw_SDK
    {

        public class constantes // Declaración de constantes
        {
            public const int kLongFecha = 24;
            public const int kLongSerie = 12;
            public const int kLongCodigo = 31;
            public const int kLongNombre = 61;
            public const int kLongReferencia = 21;
            public const int kLongDescripcion = 61;
            public const int kLongCuenta = 101;
            public const int kLongMensaje = 3001;
            public const int kLongNombreProducto = 256;
            public const int kLongAbreviatura = 4;
            public const int kLongCodValorClasif = 4;
            public const int kLongDenComercial = 51;
            public const int kLongRepLegal = 51;
            public const int kLongTextoExtra = 51;
            public const int kLongRFC = 21;
            public const int kLongCURP = 21;
            public const int kLongDesCorta = 21;
            public const int kLongNumeroExtInt = 7;
            public const int kLongNumeroExpandido = 31;
            public const int kLongCodigoPostal = 7;
            public const int kLongTelefono = 16;
            public const int kLongEmailWeb = 51;
            public const int kLongSelloSat = 176;
            public const int kLonSerieCertSAT = 21;
            public const int kLongFechaHora = 36;
            public const int kLongSelloCFDI = 176;
            public const int kLongCadOrigComplSAT = 501;
            public const int kLongitudUUID = 37;
            public const int kLongitudRegimen = 101;
            public const int kLongitudMoneda = 61;
            public const int kLongitudFolio = 17;
            public const int kLongitudMonto = 31;
            public const int kLogitudLugarExpedicion = 401;
        }


        #region ESTRUCTURA DE DOCUMENTOS
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 4)]
        public struct tDocumento
        {

            public Double aFolio;
            public int aNumMoneda;
            public Double aTipoCambio;
            public Double aImporte;
            public Double aDescuentoDoc1;
            public Double aDescuentoDoc2;
            public int aSistemaOrigen;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = constantes.kLongCodigo)]
            public String aCodConcepto;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = constantes.kLongSerie)]
            public String aSerie;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = constantes.kLongFecha)]
            public String aFecha;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = constantes.kLongCodigo)]
            public String aCodigoCteProv;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = constantes.kLongCodigo)]
            public String aCodigoAgente;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = constantes.kLongReferencia)]
            public String aReferencia;
            public int aAfecta;
            public double aGasto1;
            public double aGasto2;
            public double aGasto3;

        }

        #endregion

        #region ESTRUCTURA DE MOVIMIENTOS

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 4)]
        public struct tMovimiento
        {
            public int aConsecutivo;
            public Double aUnidades;
            public Double aPrecio;
            public Double aCosto;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = constantes.kLongCodigo)]
            public String aCodProdSer;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = constantes.kLongCodigo)]
            public String aCodAlmacen;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = constantes.kLongReferencia)]
            public String aReferencia;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = constantes.kLongCodigo)]
            public String aCodClasificacion;
        }


        #endregion

        #region ESTRUCTURA DE CLIENTES PROVEEDORES

        // cliente proveedor
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 4)]
        public struct tCteProv
        {
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = constantes.kLongCodigo)]
            public String cCodigoCliente;//[ kLongCodigo + 1 ];
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = constantes.kLongNombre)]
            public String cRazonSocial;//[ kLongNombre + 1 ];
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = constantes.kLongFecha)]
            public String cFechaAlta;//[ kLongFecha + 1 ];
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = constantes.kLongRFC)]
            public String cRFC;//[ kLongRFC + 1 ];
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = constantes.kLongCURP)]
            public String cCURP;//[ kLongCURP + 1 ];
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = constantes.kLongDenComercial)]
            public String cDenComercial;//[ kLongDenComercial + 1 ];
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = constantes.kLongRepLegal)]
            public String cRepLegal;//[ kLongRepLegal + 1 ];
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = constantes.kLongNombre)]
            public String cNombreMoneda;//[ kLongNombre + 1 ];
            public int cListaPreciosCliente;
            public double cDescuentoMovto;
            public int cBanVentaCredito; // 0 = No se permite venta a crédito, 1 = Se permite venta a crédito
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = constantes.kLongCodValorClasif)]
            public String cCodigoValorClasificacionCliente1;//[ kLongCodValorClasif + 1 ];
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = constantes.kLongCodValorClasif)]
            public String cCodigoValorClasificacionCliente2;//[ kLongCodValorClasif + 1 ];
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = constantes.kLongCodValorClasif)]
            public String cCodigoValorClasificacionCliente3;//[ kLongCodValorClasif + 1 ];
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = constantes.kLongCodValorClasif)]
            public String cCodigoValorClasificacionCliente4;//[ kLongCodValorClasif + 1 ];
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = constantes.kLongCodValorClasif)]
            public String cCodigoValorClasificacionCliente5;//[ kLongCodValorClasif + 1 ];
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = constantes.kLongCodValorClasif)]
            public String cCodigoValorClasificacionCliente6;//[ kLongCodValorClasif + 1 ];
            public int cTipoCliente; // 1 - Cliente, 2 - Cliente/Proveedor, 3 - Proveedor
            public int cEstatus; // 0. Inactivo, 1. Activo
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = constantes.kLongFecha)]
            public String cFechaBaja;//[ kLongFecha + 1 ];
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = constantes.kLongFecha)]
            public String cFechaUltimaRevision;//[ kLongFecha + 1 ];
            public double cLimiteCreditoCliente;
            public int cDiasCreditoCliente;
            public int cBanExcederCredito; // 0 = No se permite exceder crédito, 1 = Se permite exceder el crédito
            public double cDescuentoProntoPago;
            public int cDiasProntoPago;
            double cInteresMoratorio;
            public int cDiaPago;
            public int cDiasRevision;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = constantes.kLongDesCorta)]
            public String cMensajeria;//[ kLongDesCorta + 1 ];
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = constantes.kLongDescripcion)]
            public String cCuentaMensajeria;//[ kLongDescripcion + 1 ];
            public int cDiasEmbarqueCliente;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = constantes.kLongCodigo)]
            public String cCodigoAlmacen;//[ kLongCodigo + 1 ];
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = constantes.kLongCodigo)]
            public String cCodigoAgenteVenta;//[ kLongCodigo + 1 ];
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = constantes.kLongCodigo)]
            public String cCodigoAgenteCobro;//[ kLongCodigo + 1 ];
            public int cRestriccionAgente;
            public double cImpuesto1;
            public double cImpuesto2;
            public double cImpuesto3;
            public double cRetencionCliente1;
            public double cRetencionCliente2;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = constantes.kLongCodValorClasif)]
            public String cCodigoValorClasificacionProveedor1;//[ kLongCodValorClasif + 1 ];
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = constantes.kLongCodValorClasif)]
            public String cCodigoValorClasificacionProveedor2;//[ kLongCodValorClasif + 1 ];
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = constantes.kLongCodValorClasif)]
            public String cCodigoValorClasificacionProveedor3;//[ kLongCodValorClasif + 1 ];
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = constantes.kLongCodValorClasif)]
            public String cCodigoValorClasificacionProveedor4;//[ kLongCodValorClasif + 1 ];
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = constantes.kLongCodValorClasif)]
            public String cCodigoValorClasificacionProveedor5;//[ kLongCodValorClasif + 1 ];
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = constantes.kLongCodValorClasif)]
            public String cCodigoValorClasificacionProveedor6;//[ kLongCodValorClasif + 1 ];
            public double cLimiteCreditoProveedor;
            public int cDiasCreditoProveedor;
            public int cTiempoEntrega;
            public int cDiasEmbarqueProveedor;
            public double cImpuestoProveedor1;
            public double cImpuestoProveedor2;
            public double cImpuestoProveedor3;
            public double cRetencionProveedor1;
            public double cRetencionProveedor2;
            public int cBanInteresMoratorio; // 0 = No se le calculan intereses moratorios al cliente, 1 = Si se le calculan intereses moratorios al cliente.
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = constantes.kLongTextoExtra)]
            public String cTextoExtra1;//[ kLongTextoExtra + 1 ];
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = constantes.kLongTextoExtra)]
            public String cTextoExtra2;//[ kLongTextoExtra + 1 ];
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = constantes.kLongTextoExtra)]
            public String cTextoExtra3;//[ kLongTextoExtra + 1 ];
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = constantes.kLongTextoExtra)]
            public String cFechaExtra;//[ kLongFecha + 1 ];
            public double cImporteExtra1;
            public double cImporteExtra2;
            public double cImporteExtra3;
            public double cImporteExtra4;

        }

        #endregion

        #region FUNCIONES GENERALES
        [DllImport("KERNEL32")]
        public static extern int SetCurrentDirectory(string pPtrDirActual);

        [DllImport("MGW_SDK.DLL")]
        public static extern int fSetNombrePAQ(String aNombrePAQ);

        [DllImport("MGW_SDK.DLL")]
        public static extern void fInicioSesionSDK(string aUsuario, string aContrasenia);


        [DllImport("MGW_SDK.DLL")]
        public static extern void fTerminaSDK();

        [DllImport("MGW_SDK.DLL")]
        public static extern void fError(int NumeroError, StringBuilder Mensaje, int Longitud);

        #endregion

        #region FUNCIONES DE EMPRESAS

        [DllImport("MGW_SDK.DLL")]
        public static extern int fAbreEmpresa(string Directorio);

        [DllImport("MGW_SDK.DLL")]
        public static extern int fBuscaProducto(string Codigo);

        [DllImport("MGW_SDK.DLL")]
        public static extern void fCierraEmpresa();

        [DllImport("MGW_SDK.DLL")]
        public static extern Int32 fAltaDocumentoCargoAbono(ref tDocumento atDocumento);



        [DllImport("MGW_SDK.DLL")]
        public static extern int fPosPrimerEmpresa(ref int vaIdEmpresa, StringBuilder aNombreEmpresa, StringBuilder aDirectorioEmpresa);

        [DllImport("MGW_SDK.DLL")]
        public static extern int fPosSiguienteEmpresa(ref int vaIdEmpresa, StringBuilder aNombreEmpresa, StringBuilder aDirectorioEmpresa);

        [DllImport("MGW_SDK.DLL")]
        public static extern Int32 fEntregEnDiscoXML([MarshalAs(UnmanagedType.LPStr)] string aCodConcepto, [MarshalAs(UnmanagedType.LPStr)] string aSerie, double aFolio, int aFormato, string aFormatoAmigable);

        #endregion

        #region FUNCIONES DE CONCEPTO

        [DllImport("MGW_SDK.DLL")]
        public static extern int fPosPrimerConceptoDocto();

        [DllImport("MGW_SDK.DLL")]
        public static extern int fPosUltimaConceptoDocto();

        [DllImport("MGW_SDK.DLL")]
        public static extern int fPosSiguienteConceptoDocto();

        [DllImport("MGW_SDK.DLL")]
        public static extern int fLeeDatoConceptoDocto(string aCampo, StringBuilder aValor, int aLen);

        #endregion

        #region FUNCIONES CLIENTE

        [DllImport("MGW_SDK.DLL")]
        public static extern int fPosPrimerCteProv();

        [DllImport("MGW_SDK.DLL")]
        public static extern int fPosUltimoCteProv();

        [DllImport("MGW_SDK.DLL")]
        public static extern int fPosSiguienteCteProv();

        [DllImport("MGW_SDK.DLL")]
        public static extern int fLeeDatoCteProv(string aTabla, StringBuilder aValor, int aLen);

        [DllImport("MGW_SDK.DLL")]
        public static extern int fBuscaCteProv(string codigo);


        [DllImport("MGW_SDK.DLL")]
        public static extern Int32 fEmitirDocumento([MarshalAs(UnmanagedType.LPStr)] string aCodConcepto,
            [MarshalAs(UnmanagedType.LPStr)] string aSerie, double aFolio,
            [MarshalAs(UnmanagedType.LPStr)] string aPassword,
            [MarshalAs(UnmanagedType.LPStr)] string aArchivoAdicional);

        #endregion

        #region FUNCIONES DE PRODUCTOS

        [DllImport("MGW_SDK.DLL")]
        public static extern Int32 fPosPrimerProducto();

        [DllImport("MGW_SDK.DLL")]
        public static extern Int32 fPosSiguienteProducto();

        [DllImport("MGW_SDK.DLL")]
        public static extern int fLeeDatoProducto(string aCampo, StringBuilder aValr, int aLen);

        #endregion

        #region FUNCIONES DOCUMENTOS

        [DllImport("MGW_SDK.DLL")]
        public static extern Int32 fSiguienteFolio([MarshalAs(UnmanagedType.LPStr)] string aCodigoConcepto,
                                                   [MarshalAs(UnmanagedType.LPStr)] StringBuilder aSerie, ref double aFolio);

        [DllImport("MGW_SDK.DLL")]
        public static extern Int32 fAltaDocumento(ref Int32 aIdDocumento, ref tDocumento atDocumento);

        [DllImport("MGW_SDK.DLL")]
        public static extern Int32 fAltaMovimiento(Int32 aIdDocumento, ref Int32 aIdMovimiento, ref tMovimiento astMovimiento);


        [DllImport("MGW_SDK.DLL")]
        public static extern int fInicializaLicenseInfo(byte aSistema);

        [DllImport("MGW_SDK.DLL")]
        public static extern Int32 fEditarDocumento();

        [DllImport("MGW_SDK.DLL")]
        public static extern Int32 fGuardaDocumento();

        [DllImport("MGW_SDK.DLL")]
        public static extern Int32 fSetDatoDocumento(string aCampo, string aValor);


        [DllImport("MGW_SDK.dll")]
        public static extern int fTimbraXML(string aRutaXML,
                                            string aCodConcepto,
                                            StringBuilder aUUID,
                                            string aRutaDDA,
                                            string aRutaResultado,
                                            string aPass,
                                            string aRutaFormato);

        [DllImport("MGW_SDK.dll")]
        public static extern Int32 fTimbraComplementoXML(string aRutaXML,
                                                         string aCodConcepto,
                                                         StringBuilder aUUID,
                                                         string aRutaDDA,
                                                         string aRutaResultado,
                                                         string aPass,
                                                         string aRutaFormato,
                                                         int aComplemento);



        [DllImport("MGW_SDK.dll")]
        public static extern Int32 fTimbraNominaXML(string aRutaXML, string aCodCOncepto, StringBuilder aUUID, string aRutaDDA, string aRutaResultado, string aPass, string aRutaFormato);




        #endregion

        #region FUNCION ERROR
        public static int lError;
        public static string rError(int iError)
        {
            StringBuilder sMensaje = new StringBuilder(512);

            if (iError != 0)
            {
                fError(iError, sMensaje, 512);
                MessageBox.Show("Error: " + sMensaje);
            }
            return sMensaje.ToString();
        }


        #endregion


        //public static List<string> lista_empresas()
        //{

        //    List<string> lempresas = new List<string>();
        //    StringBuilder aNombreEmpresa = new StringBuilder(255);
        //    StringBuilder aDirectorioEmpresa = new StringBuilder(255);

        //    int aldEmpresa = 0;
        //    lError = fPosPrimerEmpresa(ref aldEmpresa, aNombreEmpresa, aDirectorioEmpresa);
        //    lempresas.Add(aDirectorioEmpresa.ToString());

        //    do
        //    {
        //        lError = fPosSiguienteEmpresa(ref aldEmpresa, aNombreEmpresa, aDirectorioEmpresa);
        //        if (lError == 2)
        //        {
        //            break;
        //        }
        //        else
        //        {
        //            lempresas.Add(aDirectorioEmpresa.ToString());
        //        }
        //    } while (lError == 0);

        //    return lempresas;
        //}

    } // fin clase SDK
}
