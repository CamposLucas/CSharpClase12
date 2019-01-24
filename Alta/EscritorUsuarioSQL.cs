using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Alta
{
    class EscritorUsuarioSQL : IEscritorUsuario
    {
        private SqlConnection conexionSQL;

        public EscritorUsuarioSQL(SqlConnection sqlCon) {
            this.conexionSQL = sqlCon;
        }
        public void escribirUsuario(UsuarioDTO usuario)
        {
            try
            {
                SqlCommand comando = conexionSQL.CreateCommand();
                comando.CommandText = "INSERT Cliente (Nombre, Apellido,ID) VALUES ('" + usuario.Nombre + "', '" + usuario.Apellido + "','" + usuario.Id + "')";
                comando.ExecuteNonQuery();
                Console.WriteLine("El registro se inserto correctamente");
            }
            catch
            {
                Console.WriteLine("El registro NO se inserto en SQL");
                throw;
            }
        }
    }
}
