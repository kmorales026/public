using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Sistema.Entidades;
using System.Windows.Forms;

namespace Sistema.Datos
{
    public class DReportes
    {
        private readonly Conexion conexion = new Conexion();

        private SqlDataReader leer;
        private readonly DataTable tabla = new DataTable();
        private readonly SqlCommand comando = new SqlCommand();


        public DataTable ReportesClientesFiltro(int idCliente)
        {
            try
            {
                const string query = @"Sp_ReportesEnlacesFiltrar";
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = query;
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@IdCliente", idCliente);
                comando.CommandType = CommandType.StoredProcedure;
                leer = comando.ExecuteReader();
                tabla.Load(leer);
                return tabla;
            }
            catch (Exception)
            {
                return null;
            }
            finally
            {
                conexion.CerrarConexion();

            }
        }
    }
}
