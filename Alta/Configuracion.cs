using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alta
{
    public class Configuracion
    {
        public static IEscritorUsuario obtenerEstrategia() {
            // return new EscritorUsuarioSQL(new Conexion().crearConexion());
            return new EscritorUsuarioTexto();
        }
    }
}
