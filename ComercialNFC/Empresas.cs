using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComercialNFC
{
    class Empresas
    {

        public int idEmpresas;
        public StringBuilder nombreDeEmpresa = new StringBuilder("");
        public StringBuilder rutaDeEmpresa = new StringBuilder("");

        public int IdEmpresas { get => idEmpresas; set => idEmpresas = value; }
        public StringBuilder NombreDeEmpresa { get => nombreDeEmpresa; set => nombreDeEmpresa = value; }
        public StringBuilder RutaDeEmpresa { get => rutaDeEmpresa; set => rutaDeEmpresa = value; }
    }
}
