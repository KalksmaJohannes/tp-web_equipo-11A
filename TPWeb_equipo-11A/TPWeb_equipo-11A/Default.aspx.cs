using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Negocio;

namespace TPWeb_equipo_11A
{
    public partial class Default : System.Web.UI.Page
    {
        private List<Articulo> lista;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                cargar();
            }
        }

        public void cargar()
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            GridView1.DataSource = negocio.listar();
            GridView1.DataBind();
        }

    
    }
}