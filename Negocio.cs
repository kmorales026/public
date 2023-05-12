using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema.Datos;
using System.Data;
using Sistema.Entidades;

namespace Sistema.Negocio
{
    public class NReportes
    {
        public static DataTable ReportesClientesFiltro(int idCliente)
        {
            DReportes Datos = new DReportes();
            return Datos.ReportesClientesFiltro(idCliente);
        }
    }
}
