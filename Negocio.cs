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
        public static DataTable ReportesClientesMostrar()
        {
            DReportes Datos = new DReportes();
            return Datos.ReportesClientesMostrar();
        }
        public static DataTable ReportesEnlacesMostrar()
        {
            DReportes Datos = new DReportes();
            return Datos.ReportesEnlacesMostrar();
        }
    }
}
