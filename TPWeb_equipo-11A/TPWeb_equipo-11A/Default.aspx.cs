using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;

namespace TPWeb_equipo_11A
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                cargarDatos();
            }
        }
        private void cargarDatos()
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("select A.Id,A.nombre, A.codigo, A.descripcion, A.IdCategoria as IdCategoria, A.IdMarca as IdMarca, M.Descripcion as Marca, C.Descripcion as Categoria, A.Precio, I.ImagenUrl \r\nFROM ARTICULOS A \r\nINNER JOIN MARCAS M ON A.IdMarca = M.Id \r\nINNER JOIN CATEGORIAS C ON A.IdCategoria = C.Id \r\nINNER JOIN IMAGENES I ON A.Id = I.IdArticulo"); // Cambiá según tu tabla real
                datos.ejecutarLectura();

                DataTable tabla = new DataTable();
                tabla.Load(datos.Lector);
                GridView1.DataSource = tabla;
                GridView1.DataBind();
            }
            catch (Exception ex)
            {
                // Manejo simple de errores
                Response.Write("Error al cargar datos: " + ex.Message);
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
    }
}