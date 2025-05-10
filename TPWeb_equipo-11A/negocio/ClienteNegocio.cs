using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    internal class ClienteNegocio
    {
        public bool existeCliente(string documento)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("SELECT COUNT(*) FROM Clientes WHERE Documento = @documento");
                datos.setearParametros("@documento", documento);

                int cantidad = datos.ejecutarScalar();
                return cantidad > 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
    }
}
